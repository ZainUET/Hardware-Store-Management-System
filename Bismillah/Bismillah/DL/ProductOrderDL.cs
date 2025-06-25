using MySql.Data.MySqlClient;
using System.Data;

namespace Bismillah.DL
{
    public class ProductOrderDL
    {
        private readonly DatabaseHelper _dbHelper;

        public ProductOrderDL()
        {
            _dbHelper = DatabaseHelper.Instance;
        }

        // In ProductOrderDL.cs
        public DataTable GetAllProductOrders()
        {
            string query = @"
        SELECT 
            po.order_id,
            s.name AS supplier_name,
            po.order_date,
            po.total_amount,
            COALESCE(l.value, 'Pending') AS status
        FROM purchase_orders po
        JOIN supplier s ON po.supplier_id = s.supplier_id
        LEFT JOIN lookup l ON po.status_id = l.lookup_id
        ORDER BY po.order_date DESC";

            return _dbHelper.GetDataTable(query);
        }

        public bool CheckIfOrderFullyReceived(int orderId)
        {
            string query = @"
        SELECT COUNT(*) 
        FROM purchase_order_details 
        WHERE order_id = @orderId 
        AND quantity > received_quantity";

            MySqlParameter[] parameters = {
        new MySqlParameter("@orderId", orderId)
    };

            int pendingItems = Convert.ToInt32(_dbHelper.ExecuteScalar(query, parameters));
            return pendingItems == 0;
        }
        public DataTable GetProductOrderDetails(int orderId)
        {
            string query = @"
                SELECT 
                    pod.order_detail_id,
                    p.product_id,
                    p.name AS product_name,
                    pod.quantity AS ordered_quantity,
                    pod.received_quantity,
                    pod.unit_price,
                    (pod.quantity * pod.unit_price) AS total_price,
                    (pod.quantity - pod.received_quantity) AS remaining_quantity
                FROM purchase_order_details pod
                JOIN products p ON pod.product_id = p.product_id
                WHERE pod.order_id = @orderId";

            MySqlParameter[] parameters = {
                new MySqlParameter("@orderId", orderId)
            };

            return _dbHelper.GetDataTable(query, parameters);
        }

        public bool UpdateReceivedQuantity(int orderDetailId, int receivedQuantity)
        {
            string query = @"
                UPDATE purchase_order_details 
                SET received_quantity = @receivedQuantity 
                WHERE order_detail_id = @orderDetailId";

            MySqlParameter[] parameters = {
                new MySqlParameter("@receivedQuantity", receivedQuantity),
                new MySqlParameter("@orderDetailId", orderDetailId)
            };

            return _dbHelper.Update(query, parameters) > 0;
        }

        public bool CompleteProductOrder(int orderId)
        {
            string statusQuery = "SELECT lookup_id FROM lookup WHERE category = 'Payment Status' AND value = 'Completed'";
            int statusId = Convert.ToInt32(_dbHelper.ExecuteScalar(statusQuery));

            string query = @"
                UPDATE purchase_orders 
                SET status_id = @statusId 
                WHERE order_id = @orderId";

            MySqlParameter[] parameters = {
                new MySqlParameter("@statusId", statusId),
                new MySqlParameter("@orderId", orderId)
            };

            return _dbHelper.Update(query, parameters) > 0;
        }
    }
}
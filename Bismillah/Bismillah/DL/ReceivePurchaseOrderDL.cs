using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Bismillah.DL
{
    public class ReceivePurchaseOrderDL
    {
        private readonly DatabaseHelper _dbHelper;

        public ReceivePurchaseOrderDL()
        {
            _dbHelper = DatabaseHelper.Instance;
        }

        public DataTable GetPurchaseOrderDetails(int orderId)
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



        // In ReceivePurchaseOrderDL.cs
        public bool CompletePurchaseOrder(int orderId)
        {
            try
            {
                // 1. First verify the order exists and get current status
                string verifyQuery = @"
            SELECT po.status_id, l.value AS status_name
            FROM purchase_orders po
            LEFT JOIN lookup l ON po.status_id = l.lookup_id
            WHERE po.order_id = @orderId";

                var verifyParams = new MySqlParameter[] { new MySqlParameter("@orderId", orderId) };
                var currentStatus = _dbHelper.GetDataTable(verifyQuery, verifyParams);

                if (currentStatus.Rows.Count == 0)
                {
                    Console.WriteLine("Order not found!");
                    return false;
                }

                Console.WriteLine($"Current status ID: {currentStatus.Rows[0]["status_id"]}, Name: {currentStatus.Rows[0]["status_name"]}");

                // 2. Get the Completed status ID
                string statusQuery = "SELECT lookup_id FROM lookup WHERE category = 'Payment Status' AND value = 'Completed'";
                int statusId = Convert.ToInt32(_dbHelper.ExecuteScalar(statusQuery));
                Console.WriteLine($"Completed status ID: {statusId}");

                // 3. Update the status
                string updateQuery = @"
            UPDATE purchase_orders 
            SET status_id = @statusId 
            WHERE order_id = @orderId";

                MySqlParameter[] parameters = {
            new MySqlParameter("@statusId", statusId),
            new MySqlParameter("@orderId", orderId)
        };

                int rowsAffected = _dbHelper.Update(updateQuery, parameters);
                Console.WriteLine($"Rows affected by update: {rowsAffected}");

                // 4. Verify the update
                var updatedStatus = _dbHelper.GetDataTable(verifyQuery, verifyParams);
                Console.WriteLine($"Updated status ID: {updatedStatus.Rows[0]["status_id"]}, Name: {updatedStatus.Rows[0]["status_name"]}");

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CompletePurchaseOrder: {ex.Message}");
                return false;
            }
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

        public bool MarkOrderAsComplete(int orderId)
        {
            // First get the status_id for 'Completed' from lookup table
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

        public bool MarkAllItemsAsReceived(int orderId)
        {
            string query = @"
                UPDATE purchase_order_details pod
                JOIN purchase_orders po ON pod.order_id = po.order_id
                SET pod.received_quantity = pod.quantity
                WHERE po.order_id = @orderId";

            MySqlParameter[] parameters = {
                new MySqlParameter("@orderId", orderId)
            };

            return _dbHelper.Update(query, parameters) > 0;
        }

        // In ReceivePurchaseOrderDL.cs
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

    }








}
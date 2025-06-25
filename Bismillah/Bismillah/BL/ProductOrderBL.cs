using Bismillah.DL;
using System.Data;

namespace Bismillah.BL
{
    public class ProductOrderBL
    {
        private readonly ProductOrderDL _productOrderDL;

        public ProductOrderBL()
        {
            _productOrderDL = new ProductOrderDL();
        }

        public DataTable GetAllProductOrders()
        {
            return _productOrderDL.GetAllProductOrders();
        }

        public bool UpdateOrderStatusIfCompleted(int orderId)
        {
            if (_productOrderDL.CheckIfOrderFullyReceived(orderId))
            {
                return _productOrderDL.CompleteProductOrder(orderId);
            }
            return false;
        }
        public DataTable GetProductOrderDetails(int orderId)
        {
            return _productOrderDL.GetProductOrderDetails(orderId);
        }

        public bool UpdateReceivedQuantity(int orderDetailId, int receivedQuantity)
        {
            return _productOrderDL.UpdateReceivedQuantity(orderDetailId, receivedQuantity);
        }

        public bool CompleteProductOrder(int orderId)
        {
            return _productOrderDL.CompleteProductOrder(orderId);
        }
    }
}
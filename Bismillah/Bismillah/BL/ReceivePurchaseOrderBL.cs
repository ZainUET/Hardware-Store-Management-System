using Bismillah.DL;
using System.Data;

namespace Bismillah.BL
{
    public class ReceivePurchaseOrderBL
    {
        private readonly ReceivePurchaseOrderDL _dl;

        public ReceivePurchaseOrderBL()
        {
            _dl = new ReceivePurchaseOrderDL();
        }

        public DataTable LoadPurchaseOrderDetails(int orderId)
        {
            return _dl.GetPurchaseOrderDetails(orderId);
        }

        public bool UpdateItemReceivedQuantity(int orderDetailId, int receivedQuantity)
        {
            return _dl.UpdateReceivedQuantity(orderDetailId, receivedQuantity);
        }

        public bool CheckIfOrderFullyReceived(int orderId)
        {
            return _dl.CheckIfOrderFullyReceived(orderId);
        }

        public bool ReceiveAllItems(int orderId)
        {
            bool updated = _dl.MarkAllItemsAsReceived(orderId);
            if (updated)
            {
                return _dl.MarkOrderAsComplete(orderId); // also update order status
            }
            return false;
        }
        public bool MarkOrderAsComplete(int orderId)
        {
            return _dl.MarkOrderAsComplete(orderId);
        }


        public bool CompletePurchaseOrder(int orderId)
        {
            return _dl.CompletePurchaseOrder(orderId); // ✅ this fixes the error
        }
    }
}

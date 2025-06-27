using Bismillah.DL;
using System.Data;

namespace Bismillah.BL
{
    public class ReceivePurchaseOrderBL
    {
        private readonly ReceivePurchaseOrderDL _receivePurchaseOrderDL;

        public ReceivePurchaseOrderBL()
        {
            _receivePurchaseOrderDL = new ReceivePurchaseOrderDL();
        }

        public DataTable LoadPurchaseOrderDetails(int orderId)
        {
            return _receivePurchaseOrderDL.GetPurchaseOrderDetails(orderId);
        }

        public bool UpdateItemReceivedQuantity(int orderDetailId, int receivedQuantity)
        {
            return _receivePurchaseOrderDL.UpdateReceivedQuantity(orderDetailId, receivedQuantity);
        }

        

        public bool ReceiveAllItems(int orderId)
        {
            return _receivePurchaseOrderDL.MarkAllItemsAsReceived(orderId);
        }


        // In ReceivePurchaseOrderBL.cs
        public bool CompletePurchaseOrder(int orderId)
        {
            // 1. First verify all items are received
            if (!_receivePurchaseOrderDL.CheckIfOrderFullyReceived(orderId))
            {
                Console.WriteLine("Not all items are received yet!");
                return false;
            }

            // 2. Update the status
            bool statusUpdated = _receivePurchaseOrderDL.CompletePurchaseOrder(orderId);

            if (!statusUpdated)
            {
                Console.WriteLine("Status update failed!");
            }

            return statusUpdated;
        }

        // In ReceivePurchaseOrderBL.cs
        public bool CheckIfOrderFullyReceived(int orderId)
{
    return _receivePurchaseOrderDL.CheckIfOrderFullyReceived(orderId);
}

    }
}
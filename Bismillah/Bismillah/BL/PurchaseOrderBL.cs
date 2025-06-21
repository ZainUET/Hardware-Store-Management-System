using Bismillah.DL;
using System;
using System.Data;

namespace Bismillah.BL
{
    public class PurchaseOrderBL
    {
        private readonly PurchaseOrderDL purchaseOrderDL;

        public PurchaseOrderBL()
        {
            purchaseOrderDL = new PurchaseOrderDL();
        }

        public DataTable LoadSuppliers()
        {
            return purchaseOrderDL.GetSuppliers();
        }

        public DataTable LoadProducts()
        {
            return purchaseOrderDL.GetProducts();
        }

        public string GetSupplierContact(int supplierId)
        {
            DataTable dt = purchaseOrderDL.GetSupplierContact(supplierId);
            return dt.Rows.Count > 0 ? dt.Rows[0]["contact"].ToString() : string.Empty;
        }

        public decimal GetProductPrice(int productId)
        {
            DataTable dt = purchaseOrderDL.GetProductPrice(productId);
            return dt.Rows.Count > 0 ? Convert.ToDecimal(dt.Rows[0]["unit_price"]) : 0;
        }

        public bool ProcessPurchaseOrder(int supplierId, DataTable orderItems, string notes)
        {
            if (orderItems.Rows.Count == 0)
                throw new Exception("No items in the order");

            decimal totalAmount = CalculateOrderTotal(orderItems);

            using (var connection = DatabaseHelper.Instance.getConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Create the purchase order
                        int orderId = purchaseOrderDL.CreatePurchaseOrder(supplierId, notes, totalAmount);

                        // Add order items
                        foreach (DataRow row in orderItems.Rows)
                        {
                            int productId = Convert.ToInt32(row["product_id"]);
                            int quantity = Convert.ToInt32(row["quantity"]);
                            decimal unitPrice = Convert.ToDecimal(row["unit_price"]);

                            if (!purchaseOrderDL.AddOrderItem(orderId, productId, quantity, unitPrice))
                                throw new Exception("Failed to add order item");

                            // Update stock
                            if (!purchaseOrderDL.UpdateProductStock(productId, quantity))
                                throw new Exception("Failed to update product stock");
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Transaction failed: " + ex.Message);
                    }
                }
            }
        }

        public decimal CalculateOrderTotal(DataTable orderItems)
        {
            decimal total = 0;
            foreach (DataRow row in orderItems.Rows)
            {
                total += Convert.ToInt32(row["quantity"]) * Convert.ToDecimal(row["unit_price"]);
            }
            return total;
        }

        public decimal CalculateTax(decimal subtotal)
        {
            // 15% tax rate
            return subtotal * 0.15m;
        }
    }
}
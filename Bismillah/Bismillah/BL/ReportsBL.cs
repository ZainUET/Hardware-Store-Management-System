using Bismillah.DL;
using System;
using System.Data;

namespace Bismillah.BL
{
    public class ReportsBL
    {
        private readonly ReportsDL reportsDL;

        public ReportsBL()
        {
            reportsDL = new ReportsDL();
        }

        public DataTable GenerateReport(string reportType, DateTime? startDate = null, DateTime? endDate = null)
        {
            return reportType switch
            {
                "Product Stock" => reportsDL.GetProductStockReport(),
                "Customer Purchases" => reportsDL.GetCustomerPurchaseReport(),
                "Sales" => reportsDL.GetSalesReport(startDate, endDate),
                "Supplier Orders" => reportsDL.GetSupplierOrdersReport(),
                _ => throw new ArgumentException("Invalid report type")
            };
        }

        public string[] GetAvailableReportTypes()
        {
            return new string[]
            {
                "Product Stock",
                "Customer Purchases",
                "Sales",
                "Supplier Orders"
            };
        }
    }
}
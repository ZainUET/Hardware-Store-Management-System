﻿
using Bismillah.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bismillah.DL
{
    internal class SupplierDL
    {
        public static DataTable GetAllSuppliers()
        {
            string query = "SELECT * FROM supplier";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public static DataTable GetSuppliers()
        {
            string query = "SELECT supplier_id, name FROM supplier";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public static Supplier GetSupplierById(int supplierId)
        {
            string query = $"SELECT * FROM supplier WHERE supplier_id = {supplierId}";
            var dt = DatabaseHelper.Instance.GetDataTable(query);
            if (dt.Rows.Count == 1)
            {
                var row = dt.Rows[0];
                return new Supplier
                {
                    SupplierId = Convert.ToInt32(row["supplier_id"]),
                    Name = row["name"].ToString(),
                    Contact = row["contact"].ToString(),
                    CNIC = row["cnic"].ToString(),
                    Company = row["company"].ToString()
                };
            }
            return null;
        }

        public static (int ProductCount, int OrderCount) GetDependentRecordsCount(int supplierId)
        {
            string productsQuery = $"SELECT COUNT(*) FROM products WHERE supplier_id = {supplierId}";
            int productCount = DatabaseHelper.Instance.Scaler(productsQuery);

            string ordersQuery = $"SELECT COUNT(*) FROM purchase_orders WHERE supplier_id = {supplierId}";
            int orderCount = DatabaseHelper.Instance.Scaler(ordersQuery);

            return (productCount, orderCount);
        }

        public static bool CanDeleteSupplier(int supplierId)
        {
            var (productCount, orderCount) = GetDependentRecordsCount(supplierId);
            return (productCount == 0 && orderCount == 0);
        }

        public static bool DeleteSupplier(int supplierId)
        {
            if (!CanDeleteSupplier(supplierId))
                return false;

            string query = $"DELETE FROM supplier WHERE supplier_id = {supplierId}";
            return DatabaseHelper.Instance.Update(query) > 0;
        }

        public static bool UpdateSupplier(Supplier supplier)
        {
            string query = $@"UPDATE supplier SET 
                            name = '{supplier.Name}', 
                            contact = '{supplier.Contact}', 
                            cnic = '{supplier.CNIC}',  
                            company = '{supplier.Company}' 
                            WHERE supplier_id = {supplier.SupplierId}";
            return DatabaseHelper.Instance.Update(query) > 0;
        }

        public static bool IsContactDuplicate(string contact, int excludeSupplierId = 0)
        {
            string query = $"SELECT COUNT(*) FROM supplier WHERE contact = '{contact}' AND supplier_id <> {excludeSupplierId}";
            return DatabaseHelper.Instance.Scaler(query) > 0;
        }

        public static bool IsCnicDuplicate(string cnic, int excludeSupplierId = 0)
        {
            string query = $"SELECT COUNT(*) FROM supplier WHERE cnic = '{cnic}' AND supplier_id <> {excludeSupplierId}";
            return DatabaseHelper.Instance.Scaler(query) > 0;
        }
    }
}
﻿using Bismillah.BL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bismillah.UI
{
    public partial class ProductOrderManagement : Form
    {
        private readonly ProductOrderBL _productOrderBL;

        public ProductOrderManagement()
        {
            InitializeComponent();
            _productOrderBL = new ProductOrderBL();
            InitializeDataGridView();
            RefreshProductOrderList();
        }

        private void InitializeDataGridView()
        {
            // Basic configuration
            dgvProductOrders.AutoGenerateColumns = true; // Let it create columns automatically first
            dgvProductOrders.AllowUserToAddRows = false;
            dgvProductOrders.AllowUserToDeleteRows = false;
            dgvProductOrders.ReadOnly = true;
            dgvProductOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductOrders.MultiSelect = false;

            // Visual improvements

        }

        private void RefreshProductOrderList()
        {
            try
            {
                dgvProductOrders.DataSource = null;
                var dt = _productOrderBL.GetAllProductOrders();
                dgvProductOrders.DataSource = dt;

                if (dgvProductOrders.Columns.Count > 0)
                {
                    if (dgvProductOrders.Columns.Contains("order_id"))
                    {
                        dgvProductOrders.Columns["order_id"].HeaderText = "Order ID";
                        dgvProductOrders.Columns["order_id"].Width = 80;
                    }

                    if (dgvProductOrders.Columns.Contains("supplier_name"))
                    {
                        dgvProductOrders.Columns["supplier_name"].HeaderText = "Supplier";
                        dgvProductOrders.Columns["supplier_name"].Width = 150;
                    }

                    if (dgvProductOrders.Columns.Contains("order_date"))
                    {
                        dgvProductOrders.Columns["order_date"].HeaderText = "Order Date";
                        dgvProductOrders.Columns["order_date"].DefaultCellStyle.Format = "yyyy-MM-dd";
                        dgvProductOrders.Columns["order_date"].Width = 100;
                    }

                    if (dgvProductOrders.Columns.Contains("total_amount"))
                    {
                        dgvProductOrders.Columns["total_amount"].HeaderText = "Total Amount";
                        dgvProductOrders.Columns["total_amount"].Width = 100;

                        // 👇 Rs. format for Total Amount + status coloring
                        dgvProductOrders.CellFormatting += (sender, e) =>
                        {
                            if (e.ColumnIndex == dgvProductOrders.Columns["total_amount"].Index && e.Value != null)
                            {
                                if (decimal.TryParse(e.Value.ToString(), out decimal amount))
                                {
                                    e.Value = $"Rs. {amount:N2}";
                                    e.FormattingApplied = true;
                                }
                            }

                            if (e.ColumnIndex == dgvProductOrders.Columns["status"].Index && e.Value != null)
                            {
                                var status = e.Value.ToString();
                                if (status == "Completed")
                                {
                                    e.CellStyle.BackColor = Color.LightGreen;
                                    e.CellStyle.Font = new Font(dgvProductOrders.Font, FontStyle.Bold);
                                }
                                else if (status == "Pending")
                                {
                                    e.CellStyle.BackColor = Color.LightSalmon;
                                }
                                else if (status == "Partially Received")
                                {
                                    e.CellStyle.BackColor = Color.LightYellow;
                                }
                            }
                        };
                    }
                }

                dgvProductOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvProductOrders.Refresh();

                Console.WriteLine($"Refreshed data - {dt.Rows.Count} orders loaded");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing order list: {ex.Message}\n\n{ex.StackTrace}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {

            var productOrderForm = new PurchaseOrder();
            this.Hide();
            productOrderForm.ShowDialog();
            RefreshProductOrderList();
            this.Close();
        }

        private void btnReceiveOrder_Click(object sender, EventArgs e)
        {
            if (dgvProductOrders.SelectedRows.Count > 0)
            {
                int selectedOrderId = Convert.ToInt32(dgvProductOrders.SelectedRows[0].Cells["order_id"].Value);

                using (var receiveForm = new ReceivePurchaseOrder(selectedOrderId))
                {
                    if (receiveForm.ShowDialog() == DialogResult.OK)
                    {
                        // Force a complete refresh with fresh data from database
                        RefreshProductOrderList();

                        // Optional: Reselect the same order
                        foreach (DataGridViewRow row in dgvProductOrders.Rows)
                        {
                            if (Convert.ToInt32(row.Cells["order_id"].Value) == selectedOrderId)
                            {
                                row.Selected = true;
                                break;
                            }
                        }
                    }
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            AdminDashboard addStaff = new AdminDashboard();
            this.Hide();
            addStaff.ShowDialog();
            this.Close();
        }

        private void ProductOrderManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
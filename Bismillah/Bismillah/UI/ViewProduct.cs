using Bismillah.BL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bismillah.UI
{
    public partial class ViewProduct : Form
    {
        private readonly ViewProductBL _productBL;
        private readonly int? _staffId; // Nullable staff ID

        // Constructor with optional staffId parameter
        public ViewProduct(int? staffId = null)
        {
            InitializeComponent();
            _productBL = new ViewProductBL();
            _staffId = staffId;
        }


        private void ProductUI_Load(object sender, EventArgs e)
        {
            LoadProductCategories();
            LoadAllProducts();
            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.Columns.Clear();

            // Add columns manually to control display
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ID",
                HeaderText = "ID",
                Width = 50,
                ReadOnly = true
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Product Name",
                HeaderText = "Product Name",
                Width = 250,
                ReadOnly = false
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Category",
                HeaderText = "Category",
                Width = 150,
                ReadOnly = true
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Size",
                HeaderText = "Size",
                Width = 100,
                ReadOnly = false
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Unit Price",
                HeaderText = "Unit Price",
                Width = 100,
                ReadOnly = false,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Stock",
                HeaderText = "Stock",
                Width = 80,
                ReadOnly = true
            });
        }

        private void LoadAllProducts()
        {
            dgvProducts.DataSource = _productBL.GetAllProducts();
        }

        private void LoadProductCategories()
        {
            cmbCategories.DataSource = _productBL.GetProductCategories();
            cmbCategories.DisplayMember = "value";
            cmbCategories.ValueMember = "lookup_id";
        }

        private void cmbCategories_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbCategories.SelectedValue != null && int.TryParse(cmbCategories.SelectedValue.ToString(), out int categoryId))
            {
                dgvProducts.DataSource = _productBL.GetProductsByCategory(categoryId);
            }
        }

        private void cmbproducts_TextChanged_1(object sender, EventArgs e)
        {
            dgvProducts.DataSource = _productBL.SearchProducts(cmbproducts.Text);
        }

        private void back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_staffId.HasValue)
            {
                // Return to CashierDashboard if staff ID exists
                CashierDashboard c = new CashierDashboard(_staffId.Value);
                this.Hide();
                c.ShowDialog();
            }
            else
            {
                // Return to AdminDashboard if no staff ID
                ProductManagement a = new ProductManagement();
                this.Hide();
                a.ShowDialog();
            }
            this.Close();
        }


    }
}
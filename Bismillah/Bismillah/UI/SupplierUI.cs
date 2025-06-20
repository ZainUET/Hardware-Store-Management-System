using Bismillah.BL;
using Bismillah.DL;
using Bismillah.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bismillah.UI
{
    public partial class SupplierUI : Form
    {
        public SupplierUI()
        {
            InitializeComponent();

            this.Load += SupplierUI_Load;
        }


        private string Prompt(string title, string defaultValue)
        {
            return Microsoft.VisualBasic.Interaction.InputBox(title, "Edit Supplier", defaultValue);
        }

        private void SupplierUI_Load(object sender, EventArgs e)
        {
            LoadAllSuppliers();
            dataview();
        }
        private void LoadAllSuppliers()
        {
            DataTable dt = SupplierDL.GetAllSuppliers();
            dgvsupplier.DataSource = dt;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddSupplierUI addSupplierUI = new AddSupplierUI();
            this.Hide();
            addSupplierUI.ShowDialog();

        }
        public void dataview()
        {
            DataTable dataTable = new DataTable();
            string query1 = $"Select * from supplier";
            dataTable = DatabaseHelper.Instance.GetDataTable(query1);
            dgvsupplier.DataSource = dataTable;
            dgvsupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvsupplier.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvsupplier.Refresh();
        }

        private void delete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgvsupplier.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a supplier to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int supplierId = Convert.ToInt32(dgvsupplier.SelectedRows[0].Cells["supplier_id"].Value);
            Supplier supplier = SupplierDL.GetSupplierById(supplierId);

            string validationMessage = SupplerBL.ValidateForDelete(supplier);
            if (!string.IsNullOrEmpty(validationMessage))
            {
                MessageBox.Show(validationMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this supplier?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                bool deleted = SupplierDL.DeleteSupplier(supplierId);
                if (deleted)
                {
                    MessageBox.Show("Supplier deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllSuppliers();
                }
                else
                {
                    MessageBox.Show("Failed to delete supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void edit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgvsupplier.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a supplier to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int supplierId = Convert.ToInt32(dgvsupplier.SelectedRows[0].Cells["supplier_id"].Value);
            Supplier supplier = SupplierDL.GetSupplierById(supplierId);

            string newName = Prompt("Name:", supplier.Name);
            string newContact = Prompt("Contact:", supplier.Contact);
            string newCNIC = Prompt("CNIC:", supplier.CNIC);

            string newCompany = Prompt("Company:", supplier.Company);

            supplier.Name = newName;
            supplier.Contact = newContact;
            supplier.CNIC = newCNIC;

            supplier.Company = newCompany;

            string validationMessage = SupplerBL.ValidateForEdit(supplier);
            if (!string.IsNullOrEmpty(validationMessage))
            {
                MessageBox.Show(validationMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool updated = SupplierDL.UpdateSupplier(supplier);
            if (updated)
            {
                MessageBox.Show("Supplier updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllSuppliers();
            }
            else
            {
                MessageBox.Show("Failed to update supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SupplierManagement supplierManagement = new SupplierManagement();
            this.Hide();
            supplierManagement.ShowDialog();
            this.Close();
        }
    }
}


using Bismillah.DL;
using Bismillah.BL;
using Bismillah.Entities;


namespace Bismillah.UI
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            LoadComboBoxes();
            btnBack.LinkClicked += (s, e) => this.Close();
            button1.LinkClicked += button1_LinkClicked;
        }
        private void LoadComboBoxes()
        {
            comboCategory.DataSource = AddProductDL.GetCategories();
            comboCategory.DisplayMember = "value";
            comboCategory.ValueMember = "lookup_id";

            comboSupplier.DataSource = AddProductDL.GetSuppliers();
            comboSupplier.DisplayMember = "name";
            comboSupplier.ValueMember = "supplier_id";

            comboBatch.DataSource = AddProductDL.GetBatches();
            comboBatch.DisplayMember = "arrival_date";
            comboBatch.ValueMember = "batch_id";
        }



        private void button1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
        private void ClearForm()
        {
            txtName.Clear();
            txtsize.Clear();
            txtquantity.Clear();
            txtpurchase.Clear();
            txtsale.Clear();
            comboCategory.SelectedIndex = 0;
            comboSupplier.SelectedIndex = 0;
            comboBatch.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Product product = new Product
            {
                Name = txtName.Text.Trim(),
                CategoryId = Convert.ToInt32(comboCategory.SelectedValue),
                SupplierId = Convert.ToInt32(comboSupplier.SelectedValue),
                BatchId = Convert.ToInt32(comboBatch.SelectedValue),
                Size = txtsize.Text.Trim(),
                Quantity = int.TryParse(txtquantity.Text.Trim(), out int qty) ? qty : -1,
                PurchasePrice = decimal.TryParse(txtpurchase.Text.Trim(), out decimal pp) ? pp : -1,
                SellingPrice = decimal.TryParse(txtsale.Text.Trim(), out decimal sp) ? sp : -1,
                LastUpdated = dateTimePicker1.Value
            };

            string validationMsg = AddProductBL.ValidateProduct(product);
            if (!string.IsNullOrEmpty(validationMsg))
            {
                MessageBox.Show(validationMsg, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = AddProductDL.AddProduct(product);
            if (success)
            {
                MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to add product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

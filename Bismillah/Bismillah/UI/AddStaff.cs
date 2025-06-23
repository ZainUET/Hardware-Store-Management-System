using Bismillah.BL;
using Bismillah.DL;
using System;
using System.Data;
using Bismillah.Entities;

namespace Bismillah.UI
{
    public partial class AddStaff : Form
    {
        private readonly AddStaffBL staffBL;

        public AddStaff()
        {
            InitializeComponent();
            staffBL = new AddStaffBL();
            LoadRoles();

            // Set max length for CNIC and Contact fields
            txtCNIC.MaxLength = 13;
            txtContact.MaxLength = 11;
        }
        public class KeyValuePair<TKey, TValue>
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }

            public KeyValuePair(TKey key, TValue value)
            {
                Key = key;
                Value = value;
            }
        }
        private void LoadRoles()
        {
            try
            {
                DataTable roles = staffBL.GetRoles();

                // Clear existing items
                cmbRole.Items.Clear();

                // Check if we got any data
                if (roles.Rows.Count == 0)
                {
                    MessageBox.Show("No roles found in database.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create a list to hold our items
                var roleItems = new List<RoleItem>();

                // Populate the list
                foreach (DataRow row in roles.Rows)
                {
                    roleItems.Add(new RoleItem(
                        Convert.ToInt32(row["lookup_id"]),
                        row["value"].ToString()
                    ));
                }

                // Bind to ComboBox
                cmbRole.DataSource = roleItems;
                cmbRole.DisplayMember = "RoleName";
                cmbRole.ValueMember = "RoleId";

                // Select first item if available
                if (cmbRole.Items.Count > 0)
                    cmbRole.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading roles: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper class for ComboBox items
        public class RoleItem
        {
            public int RoleId { get; set; }
            public string RoleName { get; set; }

            public RoleItem(int id, string name)
            {
                RoleId = id;
                RoleName = name;
            }

            // Important: Override ToString for display
            public override string ToString()
            {
                return RoleName;
            }
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm())
                    return;

                var staff = new StaffDTO
                {
                    Name = txtName.Text.Trim(),
                    Contact = txtContact.Text.Trim(),
                    Salary = decimal.Parse(txtSalary.Text),
                    CNIC = txtCNIC.Text.Trim(),
                    Password = txtPassword.Text,
                    RoleID = (int)cmbRole.SelectedValue
                };

                bool success = staffBL.AddStaff(staff);

                if (success)
                {
                    MessageBox.Show("Staff added successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for salary.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter name.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContact.Text) || txtContact.Text.Length != 11)
            {
                MessageBox.Show("Contact number must be 11 digits.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContact.Focus();
                return false;
            }

            if (!decimal.TryParse(txtSalary.Text, out decimal salary) || salary <= 0)
            {
                MessageBox.Show("Please enter valid salary.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalary.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCNIC.Text) || txtCNIC.Text.Length != 13)
            {
                MessageBox.Show("CNIC must be 13 digits.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCNIC.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtContact.Clear();
            txtSalary.Clear();
            txtCNIC.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = 0;
            txtName.Focus();
        }



        private void txtCNIC_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers and control characters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Prevent entering more than 13 digits
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Length >= 13 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // New method for Contact number validation
        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers and control characters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Prevent entering more than 11 digits
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Length >= 11 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // New method to validate CNIC when leaving the field
        private void txtCNIC_Leave(object sender, EventArgs e)
        {
            if (txtCNIC.Text.Length != 13)
            {
                MessageBox.Show("CNIC must be exactly 13 digits.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCNIC.Focus();
            }
        }

        // New method to validate Contact when leaving the field
        private void txtContact_Leave(object sender, EventArgs e)
        {
            if (txtContact.Text.Length != 11)
            {
                MessageBox.Show("Contact number must be exactly 11 digits.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContact.Focus();
            }
        }

        private void txtSalary_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers, decimal point, and control characters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffManagement addStaff = new StaffManagement();
            this.Hide();
            addStaff.ShowDialog();
            this.Close();
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {

        }
    }
}




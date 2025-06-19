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
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContact.Text))
            {
                MessageBox.Show("Please enter contact.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtSalary.Text, out decimal salary) || salary <= 0)
            {
                MessageBox.Show("Please enter valid salary.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCNIC.Text) || txtCNIC.Text.Length != 13)
            {
                MessageBox.Show("CNIC must be 13 digits.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
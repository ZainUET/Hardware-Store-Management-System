using Bismillah.BL;
using Bismillah.DL;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bismillah.UI
{
    public partial class AddSatff : Form
    {
        public AddSatff()
        {
            InitializeComponent();
            LoadRoles(); // Populate the role dropdown
            btnBack.LinkClicked += (sender, e) => this.Close(); // Close form on back
            button1.Click += button1_Click; // Explicitly attach click handler

            // Add input validation handlers
            txtCNIC.KeyPress += TxtCNIC_KeyPress;
            txtContact.KeyPress += TxtContact_KeyPress;
            txtSalary.KeyPress += TxtSalary_KeyPress;
        }

        // Validate CNIC (13 digits only)
        private void TxtCNIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Limit to 13 digits
            if (txtCNIC.Text.Length >= 13 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Validate Contact (11 digits only)
        private void TxtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Limit to 11 digits
            if (txtContact.Text.Length >= 11 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Validate Salary (numbers and decimal only)
        private void TxtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            // Only allow one decimal point
            if (e.KeyChar == '.' && ((TextBox)sender).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void LoadRoles()
        {
            try
            {
                DataTable roles = AddStaffDL.GetRolesFromLookup();
                cmbRole.DataSource = roles;
                cmbRole.DisplayMember = "value";
                cmbRole.ValueMember = "lookup_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading roles: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Name is required!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtContact.Text) || txtContact.Text.Length != 11)
                {
                    MessageBox.Show("Contact must be 11 digits!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSalary.Text) || !decimal.TryParse(txtSalary.Text, out _))
                {
                    MessageBox.Show("Please enter a valid salary!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCNIC.Text) || txtCNIC.Text.Length != 13)
                {
                    MessageBox.Show("CNIC must be 13 digits!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Password is required!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbRole.SelectedValue == null)
                {
                    MessageBox.Show("Please select a role!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create StaffBL object
                StaffBL staff = new StaffBL
                {
                    Name = txtName.Text.Trim(),
                    Contact = txtContact.Text.Trim(),
                    Salary = decimal.Parse(txtSalary.Text.Trim()),
                    CNIC = txtCNIC.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    RoleID = (int)cmbRole.SelectedValue
                };

                // Save to database
                bool success = AddStaffDL.SaveStaff(staff);
                if (success)
                {
                    MessageBox.Show("Staff added successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to add staff.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid salary format. Please enter a valid number.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtContact.Clear();
            txtSalary.Clear();
            txtCNIC.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;
        }
    }
}
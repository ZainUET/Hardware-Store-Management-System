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
    public partial class StaffUI : Form
    {
        public StaffUI()
        {
            InitializeComponent();
            this.Load += StaffUI_Load;
        }

        private void StaffUI_Load(object sender, EventArgs e)
        {
            LoadAllStaff();
        }
        private void LoadAllStaff()
        {
            DataTable dt = StaffDL.GetAllStaff();
            dgvsupplier.DataSource = dt;
        }

        private void btnedit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgvsupplier.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a staff member to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int staffId = Convert.ToInt32(dgvsupplier.SelectedRows[0].Cells["staff_id"].Value);
            Staff staff = StaffDL.GetStaffById(staffId);

            string newName = Prompt("Name:", staff.Name);
            string newContact = Prompt("Contact:", staff.Contact);
            string newCNIC = Prompt("CNIC:", staff.CNIC);
            string newSalary = Prompt("Salary:", staff.Salary.ToString());
            string newPassword = Prompt("Password:", staff.Password);

            staff.Name = newName;
            staff.Contact = newContact;
            staff.CNIC = newCNIC;
            staff.Password = newPassword;
            staff.Salary = decimal.TryParse(newSalary, out decimal sal) ? sal : 0;

            string validation = StaffEditBL.ValidateForEdit(staff);
            if (!string.IsNullOrEmpty(validation))
            {
                MessageBox.Show(validation, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool updated = StaffDL.UpdateStaff(staff);
            if (updated)
            {
                MessageBox.Show("Staff updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllStaff();
            }
            else
            {
                MessageBox.Show("Failed to update staff.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void btndelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    if (dgvsupplier.SelectedRows.Count == 0)
        //    {
        //        MessageBox.Show("Select a staff member to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    int staffId = Convert.ToInt32(dgvsupplier.SelectedRows[0].Cells["staff_id"].Value);
        //    Staff staff = StaffDL.GetStaffById(staffId);

        //    string validation = StaffEditBL.ValidateForDelete(staff);
        //    if (!string.IsNullOrEmpty(validation))
        //    {
        //        MessageBox.Show(validation, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    DialogResult result = MessageBox.Show("Are you sure to delete this staff?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (result == DialogResult.Yes)
        //    {
        //        bool deleted = StaffDL.DeleteStaff(staffId);
        //        if (deleted)
        //        {
        //            MessageBox.Show("Staff deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            LoadAllStaff();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Failed to delete staff.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}


        private void btndelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgvsupplier.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a staff member to delete.", "Warning",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int staffId = Convert.ToInt32(dgvsupplier.SelectedRows[0].Cells["staff_id"].Value);
            string staffName = dgvsupplier.SelectedRows[0].Cells["name"].Value.ToString();

            // Check for dependent records first
            var dependencies = StaffDL.CheckStaffDependencies(staffId);

            if (dependencies.Any())
            {
                string message = $"Cannot delete staff '{staffName}' because:\n\n";
                foreach (var dependency in dependencies)
                {
                    message += $"- {dependency.RecordCount} record(s) in {dependency.TableName}\n";
                }
                message += "\nPlease resolve these dependencies first before deleting the staff member.";

                MessageBox.Show(message, "Cannot Delete Staff",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Additional validation if needed
            Staff staff = StaffDL.GetStaffById(staffId);
            string validationMessage = StaffEditBL.ValidateForDelete(staff);
            if (!string.IsNullOrEmpty(validationMessage))
            {
                MessageBox.Show(validationMessage, "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm deletion
            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete staff: {staffName}?",
                                                 "Confirm Deletion",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                                 MessageBoxDefaultButton.Button2);

            if (confirm == DialogResult.Yes)
            {
                bool deleted = StaffDL.DeleteStaff(staffId);
                if (deleted)
                {
                    MessageBox.Show($"Staff '{staffName}' deleted successfully.", "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllStaff();
                }
                else
                {
                    MessageBox.Show($"Failed to delete staff '{staffName}'.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private string Prompt(string title, string defaultValue)
        {
            return Microsoft.VisualBasic.Interaction.InputBox(title, "Edit Staff", defaultValue);
        }
        public void dataview()
        {
            DataTable dataTable = new DataTable();
            string query1 = $"Select * from staff";
            dataTable = DatabaseHelper.Instance.GetDataTable(query1);
            dgvsupplier.DataSource = dataTable;
            dgvsupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvsupplier.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvsupplier.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            StaffManagement addStaff = new StaffManagement();
            this.Hide();
            addStaff.ShowDialog();
            this.Close();
        }
    }
}

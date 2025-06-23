using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bismillah.BL;
using Bismillah.UI;
using Bismillah.Entities;
namespace Bismillah
{
    public partial class Login : Form
    {
        private LoginBL loginBL = new LoginBL();
        public Login()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cnic = nametextBox.Text.Trim();
            string password = paastextBox.Text.Trim();

            var result = loginBL.Login(cnic, password);

            if (result.IsSuccess)
            {
                Entities.Login staff = result.Staff; // Changed from Login to Staff to match your schema

                MessageBox.Show(result.Message, "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                // Get role from lookup table (1=Manager, 2=Cashier, 3=Salesman per your schema)
                if (staff.RoleId == 1) // Manager
                {
                    

                    AdminDashboard dashboard = new AdminDashboard();
                    this.Hide();
                    dashboard.ShowDialog();
                    this.Close();
                }
                else if (staff.RoleId == 2) // Cashier
                {
         

                    CashierDashboard dashboard = new CashierDashboard(staff.StaffId);
                    this.Hide();
                    dashboard.ShowDialog();
                    this.Close();
                }


                else
                {
                    MessageBox.Show("Role not recognized.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show(result.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void nametextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Allow backspace and delete
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Only allow digits
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Prevent entering more than 13 characters (including dashes)
            if (textBox.Text.Replace("-", "").Length >= 13)
            {
                e.Handled = true;
                return;
            }

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(30, 65, 106);
            btn.ForeColor = Color.White;

            // Add a subtle border on hover
            btn.FlatAppearance.BorderColor = Color.FromArgb(70, 105, 146);
            btn.FlatAppearance.BorderSize = 1;

            // Slight size increase effect
            btn.Size = new Size(btn.Width + 2, btn.Height + 2);
            btn.Location = new Point(btn.Location.X - 1, btn.Location.Y - 1);

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(10, 35, 66);
            btn.ForeColor = Color.White;

            // Remove border
            btn.FlatAppearance.BorderSize = 0;

            // Return to original size
            btn.Size = new Size(btn.Width - 2, btn.Height - 2);
            btn.Location = new Point(btn.Location.X + 1, btn.Location.Y + 1);
        }
    }
}


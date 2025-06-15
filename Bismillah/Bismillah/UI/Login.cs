using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bismillah.BL;
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
                Entities.Login staff = result.Staff;

                MessageBox.Show(result.Message, "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                if (staff.RoleId == 1)
                {
                    //new ManagerDashboard().Show();
                }
                else if (staff.RoleId == 2)
                {
                    //new CashierDashboard().Show();
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
    }
}


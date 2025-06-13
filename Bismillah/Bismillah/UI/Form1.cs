using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bismillah.BL;
using Bismillah.Models;
namespace Bismillah
{
    public partial class Form1 : Form
    {
        private LoginBL loginBL = new LoginBL();
        public Form1()
        {
            InitializeComponent();
            paastextBox.UseSystemPasswordChar = true;  
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
                Login staff = result.Staff;

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
    }
}


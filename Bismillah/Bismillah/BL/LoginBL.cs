using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bismillah.DL;

namespace Bismillah.BL
{
    internal class LoginBL
    {
        LoginDL loginDL = new LoginDL();
        public (bool IsSuccess, string Message, Entities.Login Staff) Login(string cnic, string password)
        {
            if (string.IsNullOrWhiteSpace(cnic) || string.IsNullOrWhiteSpace(password))
            {
                return (false, "Please enter CNIC and Password.", null);
            }

            Entities.Login staff = loginDL.Authenticate(cnic, password);
            if (staff != null)
            {
                return (true, $"Welcome, {staff.Name}!", staff);
            }
            else
            {
                return (false, "Invalid CNIC or Password.", null);
            }
        }
    }
}


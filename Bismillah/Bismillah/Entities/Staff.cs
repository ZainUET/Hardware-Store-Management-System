using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bismillah.Entities
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string CNIC { get; set; }
        public decimal Salary { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
    }
}

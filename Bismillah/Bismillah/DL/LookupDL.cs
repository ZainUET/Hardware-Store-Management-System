using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bismillah.DL
{
    public static class LookupDL
    {
        public static DataTable GetLookupValues(string category)
        {
            string query = $"SELECT lookup_id, value FROM lookup WHERE category = '{category}'";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
    }
}

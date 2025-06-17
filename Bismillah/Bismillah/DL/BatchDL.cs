using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bismillah.DL
{
    internal class BatchDL
    {
        public static DataTable GetAllBatches()
        {
            string query = "SELECT batch_id, arrival_date FROM batch";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
    }
}

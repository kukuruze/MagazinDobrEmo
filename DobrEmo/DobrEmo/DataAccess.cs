using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobrEmo
{
    static class DataAccess
    {
        public static List<HDD> GetHDDs()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MagazinDobrEmo")))
            {
                var output = connection.Query<HDD>($"select * from hdds").ToList();
                return output;
            }
        }
    }
}

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
        public static List<CPU> GetCPUs()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MagazinDobrEmo")))
            {
                var output = connection.Query<CPU>($"select * from cpus").ToList();
                return output;
            }
        }
        public static List<GPU> GetGPUs()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MagazinDobrEmo")))
            {
                var output = connection.Query<GPU>($"select * from gpus").ToList();
                return output;
            }
        }
        public static List<MotherBoard> GetMotherBoards()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MagazinDobrEmo")))
            {
                var output = connection.Query<MotherBoard>($"select * from mother_boards").ToList();
                return output;
            }
        }
        public static List<RAM> GetRAMs()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MagazinDobrEmo")))
            {
                var output = connection.Query<RAM>($"select * from rams").ToList();
                return output;
            }
        }
        public static List<SSD> GetSSDs()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MagazinDobrEmo")))
            {
                var output = connection.Query<SSD>($"select * from ssds").ToList();
                return output;
            }
        }
    }
}

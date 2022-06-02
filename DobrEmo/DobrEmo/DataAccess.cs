using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobrEmo
{
    static class DataAccess
    {
        public static List<HDD> GetHDDs()
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("MagazinDobrEmo")))
            {
                var output = connection.Query<HDD>($"select * from hdds").ToList();
                return output;
            }
        }
        public static List<CPU> GetCPUs()
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("MagazinDobrEmo")))
            {
                var output = connection.Query<CPU>($"select * from cpus").ToList();
                return output;
            }
        }
        public static List<GPU> GetGPUs()
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("MagazinDobrEmo")))
            {
                var output = connection.Query<GPU>($"select * from gpus").ToList();
                return output;
            }
        }
        public static List<MotherBoard> GetMotherBoards()
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("MagazinDobrEmo")))
            {
                var output = connection.Query<MotherBoard>($"select * from mother_boards").ToList();
                return output;
            }
        }
        public static List<RAM> GetRAMs()
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("MagazinDobrEmo")))
            {
                var output = connection.Query<RAM>($"select * from rams").ToList();
                return output;
            }
        }
        public static List<SSD> GetSSDs()
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("MagazinDobrEmo")))
            {
                var output = connection.Query<SSD>($"select * from ssds").ToList();
                return output;
            }
        }
        public static bool IsSomethingAlreadyInDatabase(string targetKey, string targetValue)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("MagazinDobrEmo")))
            {
                if(connection.Query<string>($"select {targetKey} from clients").ToList().Contains(targetValue))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static void AddNewClientToDatabase(Client client)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("MagazinDobrEmo")))
            {
                string insertQuery = "INSERT INTO [MagazinDobrEmo].[dbo].[clients] (Username, Email, Password, Fullname, Cart_id) VALUES(@Username, @Email, @Password, @Fullname, @Cart_id)";
                connection.Execute(insertQuery, client);
            }
        }

        public static int GetNewCartId()
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("MagazinDobrEmo")))
            {
                var output = connection.Query<int>($"select cart_id from carts ORDER BY cart_id DESC").ToArray();
                if (output.Length == 0) return 1;
                return output[0] + 1;
            }
        }

    }
}

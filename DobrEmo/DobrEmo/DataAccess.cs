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

        public static List<Client> GetSpecificClient(string targetKey, string targetValue)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("MagazinDobrEmo")))
            {
                var output = connection.Query<Client>($"select * from clients where {targetKey} = '{targetValue}'").ToList();
                return output;
            }
        }

        public static IEnumerable<string> GetSpecificClientInfo(string targetKey, string targetValue, string specificInfo)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("MagazinDobrEmo")))
            {
                var output = connection.Query<string>($"select {specificInfo} from clients where {targetKey} = '{targetValue}'");
                return output;
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

        public static void AddNewCartToDatabase(Cart cart)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("MagazinDobrEmo")))
            {
                string insertQuery = "INSERT INTO [MagazinDobrEmo].[dbo].[carts] (cart_id, cpu_id, cpu_quantity, gpu_id, gpu_quantity, hdd_id, hdd_quantity, ram_id, ram_quantity, ssd_id, ssd_quantity, mother_board_id, mother_board_quantity) VALUES(@cart_id, @cpu_id, @cpu_quantity, @gpu_id, @gpu_quantity, @hdd_id, @hdd_quantity, @ram_id, @ram_quantity, @ssd_id, @ssd_quantity, @mother_board_id, @mother_board_quantity)";
                connection.Execute(insertQuery, cart);
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

        public static void UpdatePassword(string newPassword, string email)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("MagazinDobrEmo")))
            {
                connection.Query($"update clients set Password = '{newPassword}' where Email = '{email}'");
            }
        }

        public static Cart GetCartById(int id)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("MagazinDobrEmo")))
            {
                var output = connection.Query<Cart>($"select * from carts where cart_id = {id}").ToList();
                return output[0];
            }
        }

        public static void UpdateCart()
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("MagazinDobrEmo")))
            {
                string updateQuery = $"UPDATE [MagazinDobrEmo].[dbo].[carts] set cpu_id = @cpu_id, cpu_quantity = @cpu_quantity, gpu_id = @gpu_id, gpu_quantity = @gpu_quantity, hdd_id = @hdd_id, hdd_quantity = @hdd_quantity, ram_id = @ram_id, ram_quantity = @ram_quantity, ssd_id = @ssd_id, ssd_quantity = @ssd_quantity, mother_board_id = @mother_board_id, mother_board_quantity = @mother_board_quantity where cart_id = @cart_id";
                connection.Execute(updateQuery, CurrentUser.Cart);
            }
        }
    }
}

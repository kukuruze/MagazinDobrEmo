using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobrEmo
{
    class Client
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public int Cart_id { get; set; }

        public Client(string username,string email,string password, string fullname)
        {
            Username = username;
            Email = email;
            Password = password;
            Fullname = fullname;
        }

        public Client(string username, string email, string password, string fullname, int cart_id) : this(username, email, password, fullname)
        {
            Cart_id = cart_id;
        }
    }
}

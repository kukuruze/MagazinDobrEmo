using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobrEmo
{
    class Cart
    {
        public int cart_id { get; set; }
        public string cpu_id { get; set; }
        public string cpu_quantity { get; set; }
        public string gpu_id { get; set; }
        public string gpu_quantity { get; set; }
        public string hdd_id { get; set; }
        public string hdd_quantity { get; set; }
        public string ram_id { get; set; }
        public string ram_quantity { get; set; }
        public string ssd_id { get; set; }
        public string ssd_quantity { get; set; }
        public string mother_board_id { get; set; }
        public string mother_board_quantity { get; set; }

        public Cart(int cart_id)
        {
            this.cart_id = cart_id;
        }
    }
}

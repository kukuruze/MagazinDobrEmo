using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobrEmo
{
    class SSD : DataStorageDevice
    {
        public string InfoPrice()
        {
            return $"SSD №{this.Id}: {Capacity} GB \t {Price} лв.";
        }
        public string InfoNoPrice()
        {
            return $"SSD №{this.Id}: {Capacity} GB";
        }
    }
}

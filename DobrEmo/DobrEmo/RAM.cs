using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobrEmo
{
    class RAM : DataStorageDevice
    {
        public string InfoPrice()
        {
            return $"RAM №{this.Id}: {Capacity} GB \t {Price} лв.";
        }
        public string InfoNoPrice()
        {
            return $"RAM №{this.Id}: {Capacity} GB";
        }
    }
}

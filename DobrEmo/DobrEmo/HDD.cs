using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobrEmo
{
    class HDD : DataStorageDevice
    {
        public string InfoPrice()
        {
            return $"HDD №{this.Id}: {Capacity} TB \t {Price} лв.";
        }
        public string InfoNoPrice()
        {
            return $"HDD №{this.Id}: {Capacity} TB";
        }
    }
}

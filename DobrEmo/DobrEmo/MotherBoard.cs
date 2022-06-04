using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobrEmo
{
    class MotherBoard : DataProcessingDevice
    {
        public string InfoPrice()
        {
            return $"Motherboard №{this.Id}: {Model} \t {Price} лв.";
        }
        public string InfoNoPrice()
        {
            return $"Motherboard №{this.Id}: {Model}";
        }
    }
}

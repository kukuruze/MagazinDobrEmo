using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobrEmo
{
    class CPU : DataProcessingDevice
    {
        public string InfoPrice()
        {
            return $"CPU №{this.Id}: {Model} \t {Price} лв.";
        }
        public string InfoNoPrice()
        {
            return $"CPU №{this.Id}: {Model}";
        }
    }
}

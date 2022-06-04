using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobrEmo
{
    class GPU : DataProcessingDevice
    {
        public string InfoPrice()
        {
            return $"GPU №{this.Id}: {Model} \t {Price} лв.";
        }
        public string InfoNoPrice()
        {
            return $"GPU №{this.Id}: {Model}";
        }
    }
}

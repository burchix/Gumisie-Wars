using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GummyBears.Model
{
    public class Field
    {
        public decimal GoldMultiplier { get; set; }
        public decimal DefenceMultiplier { get; set; }
        public decimal GummiesMultiplier { get; set; }
        public decimal JuiceMultiplier { get; set; }
        public int GummiesNumber { get; set; }
        public int GummiesType { get; set; }
    }
}

using GummyBears.Common.Enums;

namespace GummyBears.Common.Models
{
    public class Field
    {
        public decimal GoldMultiplier { get; set; }
        public decimal DefenceMultiplier { get; set; }
        public decimal GummiesMultiplier { get; set; }
        public decimal JuiceMultiplier { get; set; }
        public int GummiesNumber { get; set; }
        public GummyType GummiesType { get; set; }
        public FieldOwner Owner { get; set; }
    }
}

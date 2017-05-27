using GummyBears.Common.Enums;

namespace GummyBears.Common.Models
{
    public class Field
    {
        public decimal GoldMultiplier { get; set; }
        public decimal DefenceMultiplier { get; set; }
        public decimal JuiceMultiplier { get; set; }
        public int GummiesMultiplier { get; set; }
        public GummyType GummiesType { get; set; }
        public FieldOwner Owner { get; set; }

        private decimal gummiesNumber;
        public decimal GummiesNumber
        {
            get { return gummiesNumber; }
            set
            {
                gummiesNumber = value;
                if (value == 0) GummiesType = GummyType.Basic;
            }
        }

        public PossibleActions PossibleActions { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GummyBearsGame
{
    public class Map
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public List<Field> Fields { get; set; }
    }

    public class Field
    {
        public bool IsActive { get; set; }
        public bool IsVisible { get; set; }
        public bool IsPlayer { get; set; }
        public decimal JuiceMultiple { get; set; }
        public decimal GummiesMultiple { get; set; }
        public decimal MoneyMultiple { get; set; }
        public GummyType GummyType { get; set; }
        public int GummiesCount { get; set; }
    }

    public enum GummyType
    {
        Basic,
        Warrior,
        Magic
    }
}

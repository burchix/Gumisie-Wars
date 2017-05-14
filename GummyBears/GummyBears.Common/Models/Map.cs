using GummyBears.Common.Interfaces;
using System;

namespace GummyBears.Common.Models
{
    public class Map : IObjWithId
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Field[] Fields { get; set; }

        public decimal Juice { get; set; }
        public decimal Money { get; set; }
        public decimal JuiceAI { get; set; }
        public decimal MoneyAI { get; set; }
    }
}

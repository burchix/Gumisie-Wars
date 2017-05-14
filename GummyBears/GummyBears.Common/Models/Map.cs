using System.Collections.Generic;

namespace GummyBears.Common.Models
{
    public class Map
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreateDate { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Field[] Fields { get; set; }
    }
}

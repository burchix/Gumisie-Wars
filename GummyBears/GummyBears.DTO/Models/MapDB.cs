using GummyBears.DTO.Interfaces;

namespace GummyBears.DTO.Models
{
    public class MapDB : IObjWithId
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreateDate { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string GoldMultiplier { get; set; }
        public string DefenceMultiplier { get; set; }
        public string GummiesMultiplier { get; set; }
        public string JuiceMultiplier { get; set; }
        public string GummiesType { get; set; }
        public string GummiesNumber { get; set; }
        public string Owner { get; set; }
    }
}

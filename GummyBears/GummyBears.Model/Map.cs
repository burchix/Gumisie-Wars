namespace GummyBears.Model
{
    public class Map
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public List<Field> Fields { get; set; }
    }
}

namespace GummyBears.Model
{
    public class Stats
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int UserId { get; set; }
        public int MapId { get; set; }
        public int EndMapState { get; set; }
        public int FinalGold { get; set; }
        public int FinalGummies { get; set; }
        public int OverallScore { get; set; }
    }
}

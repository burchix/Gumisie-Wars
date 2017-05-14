using GummyBears.Common.Interfaces;

namespace GummyBears.Common.Models
{
    public class Stats : IObjWithId
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int UserId { get; set; }
        public int MapId { get; set; }
        public int FinalGold { get; set; }
        public int FinalGummies { get; set; }
        public int OverallScore { get; set; }
    }
}

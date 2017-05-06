using GummyBears.DTO.Interfaces;

namespace GummyBears.DTO.Models
{
    public class GameDB : IObjWithId
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MapId { get; set; }
        public string PlayerMoves { get; set; }
        public string OpponentMoves { get; set; }
        public bool IsFinished { get; set; }
        public int Score { get; set; }
    }
}

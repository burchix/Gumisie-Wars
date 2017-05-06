namespace GummyBears.Model
{
    class Game
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

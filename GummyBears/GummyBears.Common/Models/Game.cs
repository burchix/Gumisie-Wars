using GummyBears.Common.Enums;
using GummyBears.Common.Interfaces;
using System.Collections.Generic;

namespace GummyBears.Common.Models
{
    public class Game : IObjWithId
    {
        public Game()
        {
            PlayerMoves = new List<GameAction>();
            OpponentMoves = new List<GameAction>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int MapId { get; set; }
        public List<GameAction> PlayerMoves { get; set; }
        public List<GameAction> OpponentMoves { get; set; }
        public bool IsFinished { get; set; }
        public int Score { get; set; }

        public User User { get; set; }
        public Map Map { get; set; }
    }
}

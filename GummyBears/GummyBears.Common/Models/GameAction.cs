using GummyBears.Common.Enums;

namespace GummyBears.Common.Models
{
    public class GameAction
    {
        public ActionType Action { get; set; }
        public int Field1 { get; set; } // index pola
        public int Field2 { get; set; }
        public decimal Value { get; set; }
        public bool State { get; set; } // dla ruchu, czy udało sie przejąc pole; dla ulepszenia: czy do maga[true] czy do wojownika[false]
    }
}

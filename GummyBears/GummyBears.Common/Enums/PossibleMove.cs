using System;

namespace GummyBears.Common.Enums
{
    [Flags]
    public enum PossibleMove
    {
        Up = 1,
        Down = 2,
        Right = 4,
        Left = 8
    }
}

using System;

namespace GummyBears.Common.Enums
{
    [Flags]
    public enum PossibleActions
    {
        None = 0,
        Up = 1,
        Down = 2,
        Right = 4,
        Left = 8,
        AttackUp = 16,
        AttackDown = 32,
        AttackRight = 64,
        AttackLeft = 128,
        BoostUp = 256,
        BoostDown = 512,
        BoostRight = 1024,
        BoostLeft = 2048,
        ImproveMagic = 4096,
        ImproveWarrior = 8192,
        Sacrifice = 16384
    }
}

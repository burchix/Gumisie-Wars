using GummyBears.Common.Enums;
using System.Collections.Generic;

namespace GummyBears.Common
{
    public static class Consts
    {
        public const int MAGIC_COST = 8;
        public const int WARRIOR_COST = 5;

        public static readonly Dictionary<GummyType, int> GUMMY_POWER = new Dictionary<GummyType, int>()
        {
            [GummyType.Basic] = 1,
            [GummyType.Warrior] = 3,
            [GummyType.Magical] = 1,
        };
        
        public const int JUICE_ATTACK_MULTIPLE = 5;
        public const int GUMMY_TO_JUICE = 15;
    }
}

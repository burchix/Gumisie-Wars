using GummyBears.Common;
using GummyBears.Common.Enums;
using GummyBears.Common.Models;

namespace GummyBears.BLL.GameLogic
{
    public static class ActionsLogic
    {
        public static void GetPossibleActions(Map map)
        {
            var fields = map.Fields;
            int k = 0;
            for (int i = 0; i < map.Width; i++)
                for (int j = 0; j < map.Height; j++)
                {
                    PossibleActions result = PossibleActions.None;

                    if (fields[k].Owner == FieldOwner.Player && fields[k].GummiesNumber > 0)
                    {
                        //Sacrifice
                        result |= PossibleActions.Sacrifice;

                        //Right
                        if (k % map.Width != 1 &&
                            fields[k + 1].Owner != FieldOwner.Blocked &&
                            (fields[k + 1].Owner != FieldOwner.Player || fields[k + 1].GummiesNumber == 0 || fields[k + 1].GummiesType == fields[k].GummiesType))
                            result |= PossibleActions.Right;
                        //Left
                        if (k % map.Width != 0 &&
                            fields[k - 1].Owner != FieldOwner.Blocked &&
                            (fields[k - 1].Owner != FieldOwner.Player || fields[k - 1].GummiesNumber == 0 || fields[k - 1].GummiesType == fields[k].GummiesType))
                            result |= PossibleActions.Left;
                        //Up
                        if (k >= map.Width &&
                            fields[k - map.Width].Owner != FieldOwner.Blocked &&
                            (fields[k - map.Width].Owner != FieldOwner.Player || fields[k - map.Width].GummiesNumber == 0 || fields[k - map.Width].GummiesType == fields[k].GummiesType))
                            result |= PossibleActions.Up;
                        //Down
                        if (k < ((map.Width * map.Height) - map.Width) &&
                            fields[k + map.Width].Owner != FieldOwner.Blocked &&
                            (fields[k + map.Width].Owner != FieldOwner.Player || fields[k + map.Width].GummiesNumber == 0 || fields[k + map.Width].GummiesType == fields[k].GummiesType))
                            result |= PossibleActions.Down;

                        //AttackRight
                        if (result.HasFlag(PossibleActions.Right) && fields[k].GummiesType == GummyType.Magical && fields[k + 1].Owner == FieldOwner.AI)
                            result |= PossibleActions.AttackRight;
                        //AttackLeft
                        if (result.HasFlag(PossibleActions.Left) && fields[k].GummiesType == GummyType.Magical && fields[k - 1].Owner == FieldOwner.AI)
                            result |= PossibleActions.AttackLeft;
                        //AttackUp
                        if (result.HasFlag(PossibleActions.Up) && fields[k].GummiesType == GummyType.Magical && fields[k - map.Width].Owner == FieldOwner.AI)
                            result |= PossibleActions.AttackUp;
                        //AttackDown
                        if (result.HasFlag(PossibleActions.Down) && fields[k].GummiesType == GummyType.Magical && fields[k + map.Width].Owner == FieldOwner.AI)
                            result |= PossibleActions.AttackDown;

                        if ((fields[k].GummiesNumber * Consts.JUICE_ON_ONE_GUMMY) <= map.Juice)
                        {
                            //BoostUp
                            if (result.HasFlag(PossibleActions.Up)) result |= PossibleActions.BoostUp;
                            //BoostDown
                            if (result.HasFlag(PossibleActions.Down)) result |= PossibleActions.BoostDown;
                            //BoostLeft
                            if (result.HasFlag(PossibleActions.Left)) result |= PossibleActions.BoostLeft;
                            //BoostRight
                            if (result.HasFlag(PossibleActions.Right)) result |= PossibleActions.BoostRight;
                        }

                        if (fields[k].GummiesType == GummyType.Basic)
                        {
                            //ImproveMagic
                            if ((fields[k].GummiesNumber * Consts.MAGIC_COST) < map.Money) result |= PossibleActions.ImproveMagic;
                            //ImproveWarrior
                            if ((fields[k].GummiesNumber * Consts.WARRIOR_COST) < map.Money) result |= PossibleActions.ImproveWarrior;
                        }
                    }

                    fields[k].PossibleActions = result;
                    k++;
                }
                          
        }

        public static void GetPossibleActionsForAI(Map map)
        {
            var fields = map.Fields;
            int k = 0;
            for (int i = 0; i < map.Width; i++)
                for (int j = 0; j < map.Height; j++)
                {
                    PossibleActions result = PossibleActions.None;

                    if (fields[k].Owner == FieldOwner.AI && fields[k].GummiesNumber > 0)
                    {
                        //Sacrifice
                        result |= PossibleActions.Sacrifice;

                        //Right
                        if (k % map.Width != 1 &&
                            fields[k + 1].Owner != FieldOwner.Blocked &&
                            (fields[k + 1].Owner != FieldOwner.AI || fields[k + 1].GummiesNumber == 0 || fields[k + 1].GummiesType == fields[k].GummiesType))
                            result |= PossibleActions.Right;
                        //Left
                        if (k % map.Width != 0 &&
                            fields[k - 1].Owner != FieldOwner.Blocked &&
                            (fields[k - 1].Owner != FieldOwner.AI || fields[k - 1].GummiesNumber == 0 || fields[k - 1].GummiesType == fields[k].GummiesType))
                            result |= PossibleActions.Left;
                        //Up
                        if (k >= map.Width &&
                            fields[k - map.Width].Owner != FieldOwner.Blocked &&
                            (fields[k - map.Width].Owner != FieldOwner.AI || fields[k - map.Width].GummiesNumber == 0 || fields[k - map.Width].GummiesType == fields[k].GummiesType))
                            result |= PossibleActions.Up;
                        //Down
                        if (k < ((map.Width * map.Height) - map.Width) &&
                            fields[k + map.Width].Owner != FieldOwner.Blocked &&
                            (fields[k + map.Width].Owner != FieldOwner.AI || fields[k + map.Width].GummiesNumber == 0 || fields[k + map.Width].GummiesType == fields[k].GummiesType))
                            result |= PossibleActions.Down;

                        //AttackRight
                        if (result.HasFlag(PossibleActions.Right) && fields[k].GummiesType == GummyType.Magical && fields[k + 1].Owner == FieldOwner.Player)
                            result |= PossibleActions.AttackRight;
                        //AttackLeft
                        if (result.HasFlag(PossibleActions.Left) && fields[k].GummiesType == GummyType.Magical && fields[k - 1].Owner == FieldOwner.Player)
                            result |= PossibleActions.AttackLeft;
                        //AttackUp
                        if (result.HasFlag(PossibleActions.Up) && fields[k].GummiesType == GummyType.Magical && fields[k - map.Width].Owner == FieldOwner.Player)
                            result |= PossibleActions.AttackUp;
                        //AttackDown
                        if (result.HasFlag(PossibleActions.Down) && fields[k].GummiesType == GummyType.Magical && fields[k + map.Width].Owner == FieldOwner.Player)
                            result |= PossibleActions.AttackDown;

                        if ((fields[k].GummiesNumber * Consts.JUICE_ON_ONE_GUMMY) <= map.Juice)
                        {
                            //BoostUp
                            if (result.HasFlag(PossibleActions.Up)) result |= PossibleActions.BoostUp;
                            //BoostDown
                            if (result.HasFlag(PossibleActions.Down)) result |= PossibleActions.BoostDown;
                            //BoostLeft
                            if (result.HasFlag(PossibleActions.Left)) result |= PossibleActions.BoostLeft;
                            //BoostRight
                            if (result.HasFlag(PossibleActions.Right)) result |= PossibleActions.BoostRight;
                        }

                        if (fields[k].GummiesType == GummyType.Basic)
                        {
                            //ImproveMagic
                            if ((fields[k].GummiesNumber * Consts.MAGIC_COST) < map.Money) result |= PossibleActions.ImproveMagic;
                            //ImproveWarrior
                            if ((fields[k].GummiesNumber * Consts.WARRIOR_COST) < map.Money) result |= PossibleActions.ImproveWarrior;
                        }
                    }

                    fields[k].PossibleActions = result;
                    k++;
                }

        }
    }
}

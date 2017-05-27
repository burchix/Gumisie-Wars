using GummyBears.Common;
using GummyBears.Common.Enums;
using GummyBears.Common.Models;
using System;
using System.Linq;

namespace GummyBears.BLL.GameLogic
{
    public static class MapLogic
    {
        public static GameAction Normalize(this GameAction action, Game game)
        {
            Field field1 = game.Map.Fields[action.Field1];
            Field field2 = game.Map.Fields[action.Field2];

            switch (action.Action)
            {
                case ActionType.Void:
                case ActionType.Surrender:
                    break;

                case ActionType.Move:
                    if (field1.Owner != field2.Owner && field2.Owner == FieldOwner.AI || field2.Owner == FieldOwner.Player)
                    {
                        var result = Math.Floor(field1.GummiesNumber) * Consts.GUMMY_POWER[field1.GummiesType] -
                                     Math.Floor(field2.GummiesNumber) * Consts.GUMMY_POWER[field1.GummiesType] * field2.DefenceMultiplier;
                        action.State = result > 0;
                        action.Value = (int)Math.Abs(result);
                    }
                    else
                    {
                        action.State = true;
                        action.Value = Math.Floor(field1.GummiesNumber);
                    }
                    break;

                case ActionType.MoveWithJuice:
                    if (field1.Owner != field2.Owner && field2.Owner == FieldOwner.AI || field2.Owner == FieldOwner.Player)
                    {
                        var result = Math.Floor(field1.GummiesNumber) * Consts.GUMMY_POWER[field1.GummiesType] * Consts.JUICE_ATTACK_MULTIPLE -
                                     Math.Floor(field2.GummiesNumber) * Consts.GUMMY_POWER[field1.GummiesType] * field2.DefenceMultiplier;
                        action.State = result > 0;
                        action.Value = (int)Math.Abs(result);
                    }
                    else
                    {
                        action.State = true;
                        action.Value = Math.Floor(field1.GummiesNumber);
                    }
                    break;

                case ActionType.Attack:
                    action.Value = Math.Floor(field2.GummiesNumber) * field2.DefenceMultiplier -
                                   Math.Floor(field1.GummiesNumber) * Consts.GUMMY_POWER[field1.GummiesType];
                    action.Value = Math.Max(0, (int)action.Value);
                    break;

                case ActionType.Sacrifice:
                    action.Value = Math.Floor(field1.GummiesNumber) * Consts.GUMMY_TO_JUICE;
                    break;

                case ActionType.Upgrade:
                    action.Value = Math.Floor(field1.GummiesNumber) * (action.State ? Consts.MAGIC_COST : Consts.WARRIOR_COST);
                    break;

                default:
                    throw new NotImplementedException(nameof(ActionType));
            }

            return action;
        }
        
        public static Game ProceedMapToLastState(this Game game)
        {
            for (int i = 0; i < game.PlayerMoves.Count; i++)
            {
                game = game.ProceedMapStep(game.PlayerMoves[i], PlayerType.Player)
                           .ProceedMapStep(game.OpponentMoves[i], PlayerType.AI)
                           .UpdateResources();
            }

            return game;
        }

        public static Game ProceedMapStep(this Game game, GameAction action, PlayerType playerType)
        {
            Field field1 = game.Map.Fields[action.Field1];
            Field field2 = game.Map.Fields[action.Field2];

            switch (action.Action)
            {
                case ActionType.Void:
                    break;

                case ActionType.Surrender:
                    game.IsFinished = true;
                    break;

                case ActionType.MoveWithJuice:
                case ActionType.Move:
                    if (action.Action == ActionType.MoveWithJuice)
                    {
                        if (playerType == PlayerType.Player) game.Map.Juice -= Math.Floor(field1.GummiesNumber) * Consts.JUICE_ON_ONE_GUMMY;
                        else game.Map.JuiceAI -= Math.Floor(field1.GummiesNumber) * Consts.JUICE_ON_ONE_GUMMY;
                    }
                    field1.GummiesNumber = 0;
                    field2.GummiesNumber = Math.Floor(action.Value);
                    if (action.State)
                    {
                        field2.Owner = playerType == PlayerType.Player ? FieldOwner.Player : FieldOwner.AI;
                        field2.GummiesType = field1.GummiesType;
                    }
                    break;

                case ActionType.Attack:
                    field2.GummiesNumber = (int)action.Value;
                    break;

                case ActionType.Sacrifice:
                    field1.GummiesNumber = 0;
                    if (playerType == PlayerType.Player) game.Map.Juice += action.Value;
                    else game.Map.JuiceAI += action.Value;
                    break;

                case ActionType.Upgrade:
                    field1.GummiesType = action.State ? GummyType.Magical : GummyType.Warrior;
                    if (playerType == PlayerType.Player) game.Map.Money -= action.Value;
                    else game.Map.MoneyAI -= action.Value;
                    break;

                default:
                    throw new NotImplementedException(nameof(ActionType));
            }

            return game;
        }

        public static Game UpdateResources(this Game game)
        {
            game.Map.Juice += game.Map.Fields.Where(f => f.Owner == FieldOwner.Player).Sum(f => f.JuiceMultiplier);
            game.Map.Money += game.Map.Fields.Where(f => f.Owner == FieldOwner.Player).Sum(f => f.GoldMultiplier);

            game.Map.JuiceAI += game.Map.Fields.Where(f => f.Owner == FieldOwner.AI).Sum(f => f.JuiceMultiplier);
            game.Map.MoneyAI += game.Map.Fields.Where(f => f.Owner == FieldOwner.AI).Sum(f => f.GoldMultiplier);

            var fieldsList = game.Map.Fields.ToList();
            var fieldPlayer = game.Map.Fields.Where(f => f.Owner == FieldOwner.Player && f.GummiesType == GummyType.Basic)
                                             .OrderBy(f => (fieldsList.IndexOf(f) % game.Map.Width) + (fieldsList.IndexOf(f) / game.Map.Height))
                                             .FirstOrDefault();
            if (fieldPlayer != null) fieldPlayer.GummiesNumber += game.Map.Fields.Where(f => f.Owner == FieldOwner.Player).Sum(f => f.GummiesMultiplier) / 4.76m;

            var fieldAI = game.Map.Fields.Where(f => f.Owner == FieldOwner.AI && f.GummiesType == GummyType.Basic)
                                             .OrderByDescending(f => (fieldsList.IndexOf(f) % game.Map.Width) + (fieldsList.IndexOf(f) / game.Map.Height))
                                             .FirstOrDefault();
            if (fieldAI != null) fieldAI.GummiesNumber += game.Map.Fields.Where(f => f.Owner == FieldOwner.AI).Sum(f => f.GummiesMultiplier) / 4.76m;

            return game;
        }

        public static int ComputeScore(this Game game)
        {
            return (int)(10 * game.Map.Fields.Count(f => f.Owner == FieldOwner.Player) +
                         15 * game.Map.Fields.Sum(f => f.GummiesNumber) +
                         25 * game.Map.Juice +
                         25 * game.Map.Money);
        }
    }
}

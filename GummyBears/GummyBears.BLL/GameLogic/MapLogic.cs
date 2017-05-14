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
                case ActionType.Surrend:
                    break;

                case ActionType.Move:
                    var result = field1.GummiesNumber * Consts.GUMMY_POWER[field1.GummiesType] -
                                 field2.GummiesNumber * Consts.GUMMY_POWER[field1.GummiesType] * field2.DefenceMultiplier;
                    action.State = result > 0;
                    action.Value = (int)Math.Abs(result);
                    break;

                case ActionType.MoveWithJuice:
                    result = field1.GummiesNumber * Consts.GUMMY_POWER[field1.GummiesType] * Consts.JUICE_ATTACK_MULTIPLE -
                             field2.GummiesNumber * Consts.GUMMY_POWER[field1.GummiesType] * field2.DefenceMultiplier;
                    action.State = result > 0;
                    action.Value = (int)Math.Abs(result);
                    break;

                case ActionType.Attack:
                    action.Value = field2.GummiesNumber * field2.DefenceMultiplier -
                                   field1.GummiesNumber * Consts.GUMMY_POWER[field1.GummiesType];
                    action.Value = Math.Max(0, (int)action.Value);
                    break;

                case ActionType.Sacrifice:
                    action.Value = field1.GummiesNumber * Consts.GUMMY_TO_JUICE;
                    break;

                case ActionType.Uprate:
                    action.Value = field1.GummiesNumber * (action.State ? Consts.MAGIC_COST : Consts.WARRIOR_COST);
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

                case ActionType.Surrend:
                    game.IsFinished = true;
                    game.Score = game.ComputeScore();
                    break;

                case ActionType.Move:
                case ActionType.MoveWithJuice:
                    field1.GummiesNumber = 0;
                    field2.GummiesNumber = (int)action.Value;
                    if (field1.Owner != field2.Owner && action.State)
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

                case ActionType.Uprate:
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

            foreach (Field field in game.Map.Fields)
                if (field.Owner == FieldOwner.AI || field.Owner == FieldOwner.Player && field.GummiesType == GummyType.Basic)
                    field.GummiesNumber += field.GummiesMultiplier;

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

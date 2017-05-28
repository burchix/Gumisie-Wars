using GummyBears.Common;
using GummyBears.Common.Enums;
using GummyBears.Common.Models;
using System;
using System.Linq;

namespace GummyBears.BLL.GameLogic
{
    public static class AILogic
    {
        // TODO: AI
        public static GameAction GenerateAction(Map map)
        {
            ActionsLogic.GetPossibleActionsForAI(map);
            GameAction result = new GameAction();

            if (!map.Fields.Any(f => f.Owner == FieldOwner.AI && f.GummiesNumber >= 1 &&
                                    (f.PossibleActions.HasFlag(PossibleActions.Up) || f.PossibleActions.HasFlag(PossibleActions.Down) || f.PossibleActions.HasFlag(PossibleActions.Right) || f.PossibleActions.HasFlag(PossibleActions.Left))))
            {
                result.Action = ActionType.Void;
            }
            else
            {
                result.Action = ActionType.Move;
                int field1Index;
                var field = GetBestFieldToMakeMove(map, out field1Index);
                if (field == null)
                {
                    result.Action = ActionType.Void;
                }
                else
                {
                    result.Field1 = field1Index;
                    result.Field2 = map.Fields.ToList().IndexOf(field);
                }
            }

            return result;
        }
        
        private static Field GetBestFieldToMakeMove(Map map, out int sourceFieldIndex)
        {
            Field result = null;
            sourceFieldIndex = -1;

            // Czy przejęcia pola przeciwnika możliwe
            for (int i = 0; i < map.Fields.Length; i++)
            {
                var field = map.Fields[i];
                if (field.Owner == FieldOwner.AI)
                {
                    var lField = field.PossibleActions.HasFlag(PossibleActions.Left) ? map.Fields[i - 1] : null;
                    var rField = field.PossibleActions.HasFlag(PossibleActions.Right) ? map.Fields[i + 1] : null;
                    var uField = field.PossibleActions.HasFlag(PossibleActions.Up) ? map.Fields[i - map.Width] : null;
                    var dField = field.PossibleActions.HasFlag(PossibleActions.Down) ? map.Fields[i + map.Width] : null;

                    if (lField != null && lField.Owner == FieldOwner.Player &&
                        (Math.Floor(field.GummiesNumber) * Consts.GUMMY_POWER[field.GummiesType] - Math.Floor(lField.GummiesNumber) * Consts.GUMMY_POWER[lField.GummiesType] * lField.DefenceMultiplier) >= 1)
                        result = lField;
                    else if (uField != null && uField.Owner == FieldOwner.Player &&
                             (Math.Floor(field.GummiesNumber) * Consts.GUMMY_POWER[field.GummiesType] - Math.Floor(uField.GummiesNumber) * Consts.GUMMY_POWER[uField.GummiesType] * uField.DefenceMultiplier) >= 1)
                        result = uField;
                    else if (rField != null && rField.Owner == FieldOwner.Player &&
                             (Math.Floor(field.GummiesNumber) * Consts.GUMMY_POWER[field.GummiesType] - Math.Floor(rField.GummiesNumber) * Consts.GUMMY_POWER[rField.GummiesType] * rField.DefenceMultiplier) >= 1)
                        result = rField;
                    else if (dField != null && dField.Owner == FieldOwner.Player &&
                             (Math.Floor(field.GummiesNumber) * Consts.GUMMY_POWER[field.GummiesType] - Math.Floor(dField.GummiesNumber) * Consts.GUMMY_POWER[dField.GummiesType] * dField.DefenceMultiplier) >= 1)
                        result = dField;

                    if (result != null)
                    {
                        sourceFieldIndex = i;
                        break;
                    }
                }
            }

            // Czy przejęcie pustego pola
            if (result == null)
            {
                for (int i = 0; i < map.Fields.Length; i++)
                {
                    var field = map.Fields[i];
                    if (field.Owner == FieldOwner.AI)
                    {
                        var lField = field.PossibleActions.HasFlag(PossibleActions.Left) ? map.Fields[i - 1] : null;
                        var rField = field.PossibleActions.HasFlag(PossibleActions.Right) ? map.Fields[i + 1] : null;
                        var uField = field.PossibleActions.HasFlag(PossibleActions.Up) ? map.Fields[i - map.Width] : null;
                        var dField = field.PossibleActions.HasFlag(PossibleActions.Down) ? map.Fields[i + map.Width] : null;

                        if (lField != null && lField.Owner == FieldOwner.NoOne)
                            result = lField;
                        else if (uField != null && uField.Owner == FieldOwner.NoOne)
                            result = uField;
                        else if (rField != null && rField.Owner == FieldOwner.NoOne)
                            result = rField;
                        else if (dField != null && dField.Owner == FieldOwner.NoOne)
                            result = dField;

                        if (result != null)
                        {
                            sourceFieldIndex = i;
                            break;
                        }
                    }
                }
            }

            // Po prostu pierwszy możliwy ruch
            if (result == null)
            {
                for (int i = 0; i < map.Fields.Length; i++)
                {
                    var field = map.Fields[i];
                    if (field.Owner == FieldOwner.AI)
                    {
                        var lField = field.PossibleActions.HasFlag(PossibleActions.Left) ? map.Fields[i - 1] : null;
                        var rField = field.PossibleActions.HasFlag(PossibleActions.Right) ? map.Fields[i + 1] : null;
                        var uField = field.PossibleActions.HasFlag(PossibleActions.Up) ? map.Fields[i - map.Width] : null;
                        var dField = field.PossibleActions.HasFlag(PossibleActions.Down) ? map.Fields[i + map.Width] : null;

                        if (lField != null && lField.Owner == FieldOwner.AI)
                            result = lField;
                        else if (uField != null && uField.Owner == FieldOwner.AI)
                            result = uField;
                        else if (rField != null && rField.Owner == FieldOwner.AI)
                            result = rField;
                        else if (dField != null && dField.Owner == FieldOwner.AI)
                            result = dField;

                        if (result != null)
                        {
                            sourceFieldIndex = i;
                            break;
                        }
                    }
                }
            }

            return result;
        }
    }
}

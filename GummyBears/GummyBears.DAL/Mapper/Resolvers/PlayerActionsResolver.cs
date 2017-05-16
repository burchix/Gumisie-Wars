using AutoMapper;
using GummyBears.Common.Enums;
using GummyBears.Common.Models;
using GummyBears.DTO.Models;
using System;
using System.Collections.Generic;

namespace GummyBears.DAL.Mapper.Resolvers
{
    public class PlayerActionsResolver : IValueResolver<GameDB, Game, List<GameAction>>, IValueResolver<Game, GameDB, string>
    {
        public List<GameAction> Resolve(GameDB source, Game destination, List<GameAction> destMember, ResolutionContext context)
        {
            string[] actions = (context.Items["Player"] as bool? == true ? source.PlayerMoves : source.OpponentMoves).Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
            destMember = new List<GameAction>();

            for (int i = 0; i < actions.Length; i++)
            {
                string[] action = actions[i].Split('|');
                destMember.Add(new GameAction()
                {
                    Action = (ActionType)int.Parse(action[0]),
                    Field1 = int.Parse(action[1]),
                    Field2 = int.Parse(action[2]),
                    Value = decimal.Parse(action[3]),
                    State = bool.Parse(action[4])
                });
            }

            return destMember;
        }

        public string Resolve(Game source, GameDB destination, string destMember, ResolutionContext context)
        {
            List<GameAction> actions = context.Items["Player"] as bool? == true ? source.PlayerMoves : source.OpponentMoves;

            foreach (var action in actions)
            {
                destMember += $"{(int)action.Action}|{action.Field1}|{action.Field2}|{action.Value.ToString("N2")}|{action.State};";
            }

            return destMember ?? string.Empty;
        }
    }
}

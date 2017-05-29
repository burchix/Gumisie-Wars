using GummyBears.BLL.GameLogic;
using GummyBears.BLL.Interfaces;
using GummyBears.Common.Enums;
using GummyBears.Common.Models;
using GummyBears.DAL.Interfaces;
using System;
using System.Linq;

namespace GummyBears.BLL.Services
{
    public class GameService : IGameService
    {
        #region Private Fields

        private IGameRepository _gameRepository;
        private IMapRepository _mapRepository;
        private IUserRepository _userRepository;
        private IStatsRepository _statRepository;

        #endregion

        #region Constructor(s)

        public GameService(IGameRepository gameRepository, IMapRepository mapRepository, IUserRepository userRepository, IStatsRepository statRepository)
        {
            _gameRepository = gameRepository;
            _mapRepository = mapRepository;
            _userRepository = userRepository;
            _statRepository = statRepository;
        }

        #endregion

        #region Public Methods

        public Map[] GetAllMaps() => _mapRepository.GetAll();

        public Map CreateMap(Map map)
        {
            map.CreateDate = DateTime.Now;
            int id = _mapRepository.Create(map);
            return _mapRepository.GetById(id);
        }

        // Jeżeli użytkownik ma jakąś nieukończoną grę, to jest ona zwracana
        public Game StartGame(User user, int mapId)
        {
            Game actualGame = _gameRepository.GetActualByUser(user.Id);
            if (actualGame != null)
            {
                actualGame = actualGame.ProceedMapToLastState();
                ActionsLogic.GetPossibleActions(actualGame.Map);
                return actualGame;
            }

            Game game = new Game() { MapId = mapId, UserId = user.Id };
            game.Id = _gameRepository.Create(game);
            game.Map = _mapRepository.GetById(mapId);

            ActionsLogic.GetPossibleActions(game.Map);

            return game;
        }

        public Game MakeMove(User user, GameAction action)
        {
            Game actualGame = _gameRepository.GetActualByUser(user.Id);
            actualGame.ProceedMapToLastState();

            actualGame.PlayerMoves.Add(action.Normalize(actualGame));
            actualGame.ProceedMapStep(actualGame.PlayerMoves.Last(), PlayerType.Player);

            actualGame.OpponentMoves.Add(AILogic.GenerateAction(actualGame.Map).Normalize(actualGame));
            actualGame.ProceedMapStep(actualGame.OpponentMoves.Last(), PlayerType.AI);

            actualGame.UpdateResources();

            if (actualGame.IsFinished || !actualGame.Map.Fields.Any(x => x.Owner == FieldOwner.AI) || !actualGame.Map.Fields.Any(x => x.Owner == FieldOwner.Player))
            {
                actualGame.IsFinished = true;
                actualGame.Score = actualGame.ComputeScore();

                _statRepository.Create(new Stats()
                {
                    FinalGold = (int)actualGame.Map.Money,
                    FinalGummies = (int)actualGame.Map.Fields.Where(x => x.Owner == FieldOwner.Player).Sum(x => x.GummiesNumber),
                    GameId = actualGame.Id,
                    MapId = actualGame.MapId,
                    OverallScore = actualGame.Score,
                    UserId = actualGame.UserId
                });
            }
            else
            {
                ActionsLogic.GetPossibleActions(actualGame.Map);
            }

            _gameRepository.Update(actualGame);

            return actualGame;
        }

        #endregion
    }
}

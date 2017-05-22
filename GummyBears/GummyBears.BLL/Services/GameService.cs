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

        #endregion

        #region Constructor(s)

        public GameService(IGameRepository gameRepository, IMapRepository mapRepository, IUserRepository userRepository)
        {
            _gameRepository = gameRepository;
            _mapRepository = mapRepository;
            _userRepository = userRepository;
        }

        #endregion

        #region Public Methods

        public Map[] GetAllMaps() => _mapRepository.GetAll();

        // Jeżeli użytkownik ma jakąś nieukończoną grę, to jest ona zwracana
        public Game StartGame(User user, int mapId)
        {
            Game actualGame = _gameRepository.GetActualByUser(user.Id);
            if (actualGame != null) return actualGame.ProceedMapToLastState();
            
            Game game = new Game() { MapId = mapId, UserId = user.Id };
            game.Id = _gameRepository.Create(game);
            game = _gameRepository.GetById(game.Id);
            return game;
        }

        public Game MakeMove(User user, GameAction action)
        {
            Game actualGame = _gameRepository.GetActualByUser(user.Id);
            actualGame.ProceedMapToLastState();

            actualGame.PlayerMoves.Add(action.Normalize(actualGame));
            actualGame.OpponentMoves.Add(AILogic.GenerateAction(actualGame.Map));

            actualGame.ProceedMapStep(actualGame.PlayerMoves.Last(), PlayerType.Player)
                      .ProceedMapStep(actualGame.OpponentMoves.Last(), PlayerType.AI)
                      .UpdateResources();

            //TODO; sprawdzanie czy gra skończona

            ActionsLogic.GetPossibleActions(actualGame.Map);

            _gameRepository.Update(actualGame);

            return actualGame;
        }

        #endregion
    }
}

using GummyBears.BLL.Interfaces;
using GummyBears.Common.Models;
using GummyBears.DAL.Interfaces;
using System;

namespace GummyBears.BLL.Services
{
    public class GameService : IGameService
    {
        #region Private Fields

        private IGameRepository _gameRepository;
        private IMapRepository _mapRepository;

        #endregion

        #region Constructor(s)

        public GameService(IGameRepository gameRepository, IMapRepository mapRepository)
        {
            _gameRepository = gameRepository;
            _mapRepository = mapRepository;
        }

        #endregion
    }
}

using GummyBears.BLL.Interfaces;
using GummyBears.Common.Models;
using System;
using System.ServiceModel;

namespace GummyBears.Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, IncludeExceptionDetailInFaults = true)]
    public class Service : IService
    {
        private IGameService _gameService;
        private IAuthenticationService _authenticationService;

        public Service(IGameService gameService, IAuthenticationService authenticationService)
        {
            _gameService = gameService;
            _authenticationService = authenticationService;
        }

        #region Public Methods
        
        public string DoLogin(string login, string password)
        {
            User user = _authenticationService.GetUser(login, password);
            return user != null ? _authenticationService.CreateSession(user) : null;
        }

        public Game StartGame(string sessionHandle, int mapId)
        {
            User user = VerifyUser(sessionHandle);
            return _gameService.StartGame(user, mapId);
        }

        public Game MakeMove(string sessionHandle, GameAction action)
        {
            User user = VerifyUser(sessionHandle);
            return _gameService.MakeMove(user, action);
        }

        #endregion

        #region Private Methods

        private User VerifyUser(string sessionHandle)
        {
            User user;
            if (!_authenticationService.CheckSession(sessionHandle, out user))
            {
                throw new AddressAccessDeniedException("Incorrect session handle");
            }

            return user;
        }

        #endregion
    }
}

using GummyBears.BLL.Interfaces;
using GummyBears.Common.Models;
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

        #endregion

        #region Private Methods

        private void CheckSession(string sessionHandle)
        {
            if (!_authenticationService.CheckSession(sessionHandle))
            {
                throw new AddressAccessDeniedException("Incorrect session handle");
            }
        }

        #endregion
    }
}

using GummyBears.BLL.Interfaces;
using GummyBears.Common.Models;
using GummyBears.DAL.Interfaces;
using System;
using System.Linq;

namespace GummyBears.BLL.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        #region Private Fields

        private const int SESSION_LIFETIME_MIN = 30;
        private const string SESSION_HANDLE_CHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        private static Random random = new Random();

        private ISessionRepository _sessionRepository;
        private IUserRepository _userRepository;

        #endregion

        #region Constructor(s)

        public AuthenticationService(ISessionRepository sessionRepository, IUserRepository userRepository)
        {
            _sessionRepository = sessionRepository;
            _userRepository = userRepository;
        }

        #endregion

        #region Public Methods

        public User GetUser(string login, string password)
        {
            User user = _userRepository.GetByLogin(login);

            if (user != null && user.Password == password) return user;
            return null;
        }

        public bool CheckSession(string sessionHandle, out User user)
        {
            user = null;
            if (string.IsNullOrWhiteSpace(sessionHandle)) return false;

            Session session = _sessionRepository.GetBySessionHandle(sessionHandle);
            if (session == null || session.EndDate < DateTime.Now) return false;

            session.EndDate = DateTime.Now.AddMinutes(SESSION_LIFETIME_MIN);
            _sessionRepository.Update(session);

            user = _userRepository.GetById(session.UserId);

            return true;
        }

        public string CreateSession(User user)
        {
            Session session = _sessionRepository.GetByUser(user.Id) ?? new Session();
            session.UserId = user.Id;
            session.StartDate = DateTime.Now;
            session.EndDate = DateTime.Now.AddMinutes(SESSION_LIFETIME_MIN);
            session.SessionHandle = GenerateSessionHandle();

            if (session.Id != 0) _sessionRepository.Update(session);
            else _sessionRepository.Create(session);

            return session.SessionHandle;
        }

        #endregion

        #region Private Methods

        private static string GenerateSessionHandle()
        {
            return new string(Enumerable.Repeat(SESSION_HANDLE_CHARS, 20).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        #endregion
    }
}

using System;
using NUnit.Framework;
using NSubstitute;
using GummyBears.DAL.Interfaces;
using GummyBears.BLL.Services;

namespace GummyBears.Tests.ServiceTests
{
    [TestFixture]
    public class AuthenticationServiceTests
    {
        private IUserRepository _userRepository = Substitute.For<IUserRepository>();
        private ISessionRepository _sessionRepository = Substitute.For<ISessionRepository>();
        private AuthenticationService _authenticationService;

        [SetUp]
        public void Setup()
        {
            _authenticationService = new AuthenticationService(_sessionRepository, _userRepository);
        }

        [Test]
        public void GetUser_When_EmptyLogin_Returns_Null()
        {
            //Act
            var user = _authenticationService.GetUser(null, "password");

            //Assert
            Assert.IsNull(user);
        }
    }
}

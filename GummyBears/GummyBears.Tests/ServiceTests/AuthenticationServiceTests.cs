using NUnit.Framework;
using NSubstitute;
using GummyBears.DAL.Interfaces;
using GummyBears.BLL.Services;
using GummyBears.Common.Models;

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
        public void GetUser_When_ServiceReturnsNull_Returns_Null()
        {
            //Arrange
            _userRepository.GetByLogin(Arg.Any<string>()).Returns((User)null);
            //Act
            var user = _authenticationService.GetUser(null, "password");

            //Assert
            Assert.IsNull(user);
        }

        [Test]
        public void GetUser_When_BadPassword_Returns_Null()
        {
            //Arrange
            var user = new User()
            {
                Login = "login",
                Password = "password"
            };
            _userRepository.GetByLogin(user.Login).Returns(user);
            //Act
            var returnedUser = _authenticationService.GetUser(user.Login, "badPassword");

            //Assert
            Assert.IsNull(returnedUser);
        }

        [Test]
        public void GetUser_When_CorrectPassword_Returns_User()
        {
            //Arrange
            var user = new User()
            {
                Login = "login",
                Password = "password"
            };
            _userRepository.GetByLogin(user.Login).Returns(user);
            //Act
            var returnedUser = _authenticationService.GetUser(user.Login, user.Password);

            //Assert
            Assert.AreEqual(user.Login, returnedUser.Login);
            Assert.AreEqual(user.Password, returnedUser.Password);
        }
    }
}

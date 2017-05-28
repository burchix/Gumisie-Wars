using GummyBears.BLL.Interfaces;
using GummyBears.Common.Models;
using GummyBears.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GummyBears.WebAPI.Controllers
{
    public class AccountController : ApiController
    {
        private IAuthenticationService _authenticationService;

        public AccountController() { }

        public AccountController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost]
        [Route("api/Account/Login")]
        public string Login(string login, string password)
        {
            User user = _authenticationService.GetUser(login, password);
            return user != null ? _authenticationService.CreateSession(user) : null;
        }

        [HttpPost]
        [Route("api/Account/Register")]
        public void Register(string login, string password)
        {
            _authenticationService.Register(login, password);
        }
    }
}

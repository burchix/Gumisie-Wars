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
        [HttpPost]
        [Route("api/Account/Login")]
        public string Login(string login, string password)
        {
            return null;
        }

        [HttpPost]
        [Route("api/Account/Register")]
        public void Register(string login, string password)
        {

        }
    }
}

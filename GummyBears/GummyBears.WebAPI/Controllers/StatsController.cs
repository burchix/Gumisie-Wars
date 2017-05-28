using GummyBears.BLL.Interfaces;
using GummyBears.BLL.Services;
using GummyBears.Common.Models;
using GummyBears.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GummyBears.WebAPI.Controllers
{
    //[Authorize]
    public class StatsController : ApiController
    {
        private IStatsService _statsService;

        public StatsController() { }

        public StatsController(IStatsService statsService)
        {
            _statsService = statsService;
        }

        [HttpGet]
        [Route("api/Stats/GetUsers")]
        public User[] GetUsers()
        {
            return _statsService.GetAllUsers();
        }

        [HttpGet]
        [Route("api/Stats/GetByUser")]
        public Stats[] GetByUser(int userId)
        {
            return _statsService.GetUserStats(userId);
        }

        [HttpGet]
        [Route("api/Stats/GetByMap")]
        public Stats[] GetByMap(int mapId, int? count = null)
        {
            return _statsService.GetBestMapStats(mapId, count ?? 100);
        }
    }
}

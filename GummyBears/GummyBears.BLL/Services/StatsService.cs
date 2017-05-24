using System;
using GummyBears.BLL.Interfaces;
using GummyBears.Common.Models;
using GummyBears.DAL.Interfaces;
using System.Linq;

namespace GummyBears.BLL.Services
{
    public class StatsService : IStatsService
    {
        private IStatsRepository _statsRepository;
        private IUserRepository _usersRepository;

        public StatsService(IStatsRepository statsRepository, IUserRepository usersRepository)
        {
            _statsRepository = statsRepository;
            _usersRepository = usersRepository;
        }

        public User[] GetAllUsers()
        {
            var users = _usersRepository.GetAll();
            foreach (var user in users)
            {
                user.Password = null;
            }

            return users.ToArray();
        }

        public Stats[] GetBestMapStats(int mapId, int count)
        {
            return _statsRepository.GetBestByMap(mapId, count);
        }

        public Stats[] GetUserStats(int userId)
        {
            return _statsRepository.GetBestByUser(userId, null);
        }
    }
}

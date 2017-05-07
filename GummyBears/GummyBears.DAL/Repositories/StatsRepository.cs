using GummyBears.DAL.Interfaces;
using GummyBears.DTO.Models;
using GummyBears.Model;
using System;
using System.Data.Entity;
using System.Linq;

namespace GummyBears.DAL.Repositories
{
    public class StatsRepository : BaseRepository<StatsDB, Stats>, IStatsRepository
    {
        public StatsRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public override Stats FromDBToModel(StatsDB dbModel)
        {
            throw new NotImplementedException();
        }

        public override StatsDB FromModelToDB(Stats model)
        {
            throw new NotImplementedException();
        }

        public Stats[] GetBestByMap(int mapId, int? count = null)
        {
            var best = _dbSet.Where(s => s.MapId == mapId).OrderByDescending(s => s.OverallScore).Take(n);
            if (count.HasValue)
                return best.Take(count.Value).Select(s => FromDBToModel(s)).ToArray();
            else
                return best.Select(s => FromDBToModel(s)).ToArray();
        }

        public Stats[] GetBestByUser(int userId, int? count = null)
        {
            var best = _dbSet.Where(s => s.UserId == userId).OrderByDescending(s => s.OverallScore);
            if (count.HasValue)
                return best.Take(count.Value).Select(s => FromDBToModel(s)).ToArray();
            else
                return best.Select(s => FromDBToModel(s)).ToArray();
        }
    }
}

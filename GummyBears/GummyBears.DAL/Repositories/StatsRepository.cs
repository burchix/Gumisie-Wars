using AutoMapper;
using GummyBears.Common.Models;
using GummyBears.DAL.Interfaces;
using GummyBears.DTO.Models;
using System.Data.Entity;
using System.Linq;

namespace GummyBears.DAL.Repositories
{
    public class StatsRepository : BaseRepository<StatsDB, Stats>, IStatsRepository
    {
        public StatsRepository(DbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public Stats[] GetBestByMap(int mapId, int? count = null)
        {
            var bestStats = _dbSet.Where(s => s.MapId == mapId).OrderByDescending(s => s.OverallScore);
            if (count.HasValue)
            {
                bestStats = bestStats.Take(() => count.Value).OrderBy(x => 0);
            }

            return bestStats.Select(s => _mapper.Map<Stats>(s)).ToArray();
        }

        public Stats[] GetBestByUser(int userId, int? count = null)
        {
            var bestStats = _dbSet.Where(s => s.UserId == userId).OrderByDescending(s => s.OverallScore);
            if (count.HasValue)
            {
                bestStats = bestStats.Take(() => count.Value).OrderBy(x => 0);
            }

            return bestStats.Select(s => _mapper.Map<Stats>(s)).ToArray();
        }
    }
}

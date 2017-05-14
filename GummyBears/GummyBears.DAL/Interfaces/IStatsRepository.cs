using GummyBears.Common.Models;
using GummyBears.DTO.Models;

namespace GummyBears.DAL.Interfaces
{
    public interface IStatsRepository : IBaseRepository<StatsDB, Stats>
    {
        Stats[] GetBestByMap(int mapId, int? count);

        Stats[] GetBestByUser(int userId, int? count);
    }
}

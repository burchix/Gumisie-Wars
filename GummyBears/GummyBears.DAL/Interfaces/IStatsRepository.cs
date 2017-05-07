using GummyBears.DTO.Models;
using GummyBears.Model;

namespace GummyBears.DAL.Interfaces
{
    public interface IStatsRepository : IBaseRepository<StatsDB, Stats>
    {
        Stats[] GetBestByMap(int mapId, int? count);

        Stats[] GetBestByUser(int userId, int? count);
    }
}

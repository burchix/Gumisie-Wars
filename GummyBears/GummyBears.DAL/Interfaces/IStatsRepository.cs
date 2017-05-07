using GummyBears.DTO.Models;
using GummyBears.Model;

namespace GummyBears.DAL.Interfaces
{
    public interface IStatsRepository : IBaseRepository<StatsDB, Stats>
    {
        Stats[] GetBestByMap(int mapId, int n = -1);

        Stats[] GetBestByUser(int userId, int n = -1);
    }
}

using GummyBears.Common.Models;

namespace GummyBears.BLL.Interfaces
{
    public interface IStatsService
    {
        Stats[] GetUserStats(int userId);
        Stats[] GetBestMapStats(int mapId, int count);
        User[] GetAllUsers();
    }
}

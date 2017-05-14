using GummyBears.Common.Models;

namespace GummyBears.BLL.Interfaces
{
    public interface IGameService
    {
        Game StartGame(User user, int mapId);
        Game MakeMove(User user, GameAction action);
    }
}

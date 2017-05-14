using GummyBears.Common.Models;
using GummyBears.DTO.Models;

namespace GummyBears.DAL.Interfaces
{
    public interface IGameRepository : IBaseRepository<GameDB, Game>
    {
        Game[] GetAllByUser(int userId);

        Game GetActualByUser(int userId);
    }
}

using GummyBears.DTO.Models;
using GummyBears.Model;

namespace GummyBears.DAL.Interfaces
{
    public interface IGameRepository : IBaseRepository<GameDB, Game>
    {
        Game[] GetAllByUser(int userId);

        Game GetActualByUser(int userId);
    }
}

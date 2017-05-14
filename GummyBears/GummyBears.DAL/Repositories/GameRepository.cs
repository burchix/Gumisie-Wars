using AutoMapper;
using GummyBears.Common.Models;
using GummyBears.DAL.Interfaces;
using GummyBears.DTO.Models;
using System.Data.Entity;
using System.Linq;

namespace GummyBears.DAL.Repositories
{
    public class GameRepository : BaseRepository<GameDB, Game>, IGameRepository
    {
        public GameRepository(DbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
        
        public Game[] GetAllByUser(int userId)
        {
            return _dbSet.Where(g => g.UserId == userId).Select(g => _mapper.Map<Game>(g)).ToArray();
        }

        public Game GetActualByUser(int userId)
        {
            GameDB dbGame = _dbSet.SingleOrDefault(g => g.UserId == userId && !g.IsFinished);
            return dbGame == null ? null : _mapper.Map<Game>(dbGame);
        }
    }
}

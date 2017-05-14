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
            return GetQuery().Where(g => g.UserId == userId).Select(g => _mapper.Map<Game>(g)).ToArray();
        }

        public Game GetActualByUser(int userId)
        {
            GameDB dbGame = GetQuery().SingleOrDefault(g => g.UserId == userId && !g.IsFinished);
            return dbGame == null ? null : _mapper.Map<Game>(dbGame);
        }

        protected override IQueryable<GameDB> BuildQuery(IQueryable<GameDB> query)
        {
            return query.Include(x => x.Map).Include(x => x.User);
        }
    }
}

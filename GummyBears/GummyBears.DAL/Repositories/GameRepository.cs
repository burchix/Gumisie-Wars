using GummyBears.DAL.Interfaces;
using GummyBears.DTO.Models;
using GummyBears.Model;
using System;
using System.Data.Entity;
using System.Linq;

namespace GummyBears.DAL.Repositories
{
    public class GameRepository : BaseRepository<GameDB, Game>, IGameRepository
    {
        public GameRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public override Game FromDBToModel(GameDB dbModel)
        {
            throw new NotImplementedException();
        }

        public override GameDB FromModelToDB(Game model)
        {
            throw new NotImplementedException();
        }

        public Game[] GetAllByUser(int userId)
        {
            return _dbSet.Where(g => g.UserId == userId).Select(g => FromDBToModel(g)).ToArray();
        }

        public Game GetActualByUser(int userId)
        {
            GameDB dbGame = _dbSet.SingleOrDefault(g => g.UserId == userId && !g.IsFinished);
            return dbGame == null ? null : FromDBToModel(dbGame);
        }
    }
}

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

        public Game GetByUser(int userId)
        {
            GameDB dbGame = _dbSet.FirstOrDefault(g => g.UserId == userId && g.IsFinished == false);
            return dbGame == null ? null : FromDBToModel(dbGame);
        }
    }
}

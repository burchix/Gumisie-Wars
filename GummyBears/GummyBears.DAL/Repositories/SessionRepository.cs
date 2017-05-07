using GummyBears.DAL.Interfaces;
using GummyBears.DTO.Models;
using GummyBears.Model;
using System;
using System.Data.Entity;
using System.Linq;

namespace GummyBears.DAL.Repositories
{
    public class SessionRepository : BaseRepository<SessionDB, Session>, ISessionRepository
    {
        public SessionRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public override Session FromDBToModel(SessionDB dbModel)
        {
            throw new NotImplementedException();
        }

        public override SessionDB FromModelToDB(Session model)
        {
            throw new NotImplementedException();
        }

        public Session GetByUser(int userId)
        {
            var dbSession = _dbSet.FirstOrDefault(s => s.UserId == userId);
            return FromDBToModel(dbSession);
        }
    }
}

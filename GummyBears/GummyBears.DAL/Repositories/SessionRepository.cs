using AutoMapper;
using GummyBears.Common.Models;
using GummyBears.DAL.Interfaces;
using GummyBears.DTO.Models;
using System.Data.Entity;
using System.Linq;

namespace GummyBears.DAL.Repositories
{
    public class SessionRepository : BaseRepository<SessionDB, Session>, ISessionRepository
    {
        public SessionRepository(DbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public Session GetBySessionHandle(string sessionHandle)
        {
            var dbSession = GetQuery().SingleOrDefault(s => s.SessionHandle == sessionHandle);
            return dbSession == null ? null : _mapper.Map<Session>(dbSession);
        }

        public Session GetByUser(int userId)
        {
            var dbSession = GetQuery().SingleOrDefault(s => s.UserId == userId);
            return dbSession  == null ? null : _mapper.Map<Session>(dbSession);
        }

        protected override IQueryable<SessionDB> BuildQuery(IQueryable<SessionDB> query) => query;
    }
}

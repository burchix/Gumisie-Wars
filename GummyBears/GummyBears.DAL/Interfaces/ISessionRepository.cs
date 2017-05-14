using GummyBears.Common.Models;
using GummyBears.DTO.Models;

namespace GummyBears.DAL.Interfaces
{
    public interface ISessionRepository : IBaseRepository<SessionDB, Session>
    {
        Session GetBySessionHandle(string sessionHandle);
        Session GetByUser(int userId);
    }
}

using GummyBears.DTO.Models;
using GummyBears.Model;

namespace GummyBears.DAL.Interfaces
{
    public interface ISessionRepository : IBaseRepository<SessionDB, Session>
    {
        Session GetByUser(int userId);
    }
}

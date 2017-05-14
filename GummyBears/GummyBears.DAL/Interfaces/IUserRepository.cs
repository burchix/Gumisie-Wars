using GummyBears.Common.Models;
using GummyBears.DTO.Models;

namespace GummyBears.DAL.Interfaces
{
    public interface IUserRepository: IBaseRepository<UserDB, User>
    {
        User GetByLogin(string login);
    }
}

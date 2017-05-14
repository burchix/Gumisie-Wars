using GummyBears.Common.Models;

namespace GummyBears.BLL.Interfaces
{
    public interface IAuthenticationService
    {
        User GetUser(string login, string password);

        bool CheckSession(string sessionHandle, out User user);

        string CreateSession(User user);
    }
}

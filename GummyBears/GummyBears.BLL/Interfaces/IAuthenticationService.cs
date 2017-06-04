using GummyBears.Common.Models;

namespace GummyBears.BLL.Interfaces
{
    public interface IAuthenticationService
    {
        int Register(string login, string password);

        User GetUser(string login, string password);

        bool CheckSession(string sessionHandle, out User user);

        string CreateSession(User user);
    }
}

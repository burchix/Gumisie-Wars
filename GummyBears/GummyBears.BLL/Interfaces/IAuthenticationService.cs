using GummyBears.Common.Models;

namespace GummyBears.BLL.Interfaces
{
    public interface IAuthenticationService
    {
        bool CheckSession(string sessionHandle);

        string CreateSession(User user);
    }
}

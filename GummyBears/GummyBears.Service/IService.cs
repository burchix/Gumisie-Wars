using GummyBears.Common.Models;
using System.ServiceModel;

namespace GummyBears.Service
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string DoLogin(string login, string password);

        [OperationContract]
        Map[] GetMaps();

        [OperationContract]
        Map SaveMap(Map map);

        [OperationContract]
        Game StartGame(string sessionHandle, int mapId);

        [OperationContract]
        Game MakeMove(string sessionHandle, GameAction action);
    }
}

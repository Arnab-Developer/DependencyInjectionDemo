using ApoUtilityPrototype1.DomainModels;
using System.ServiceModel;

namespace ApoUtilityPrototype1.Service
{
    [ServiceContract]
    public interface ILoginService
    {
        [OperationContract]
        bool IsAuthenticUser(UserAccount account);

        [OperationContract]
        bool CreateUser(UserAccount user);
    }
}
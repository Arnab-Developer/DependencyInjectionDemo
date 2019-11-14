using System.ServiceModel;
using ApoUtilityPrototype1.DomainModels;

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
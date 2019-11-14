using ApoUtilityPrototype1.DomainModels;

namespace ApoUtilityPrototype1.Contracts
{
    public interface IBaseContract
    {
        bool IsAuthenticUser(UserAccount user);
        bool CreateUser(UserAccount user);
    }
}
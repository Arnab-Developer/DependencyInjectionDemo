using System.ServiceModel.Activation;
using ApoUtilityPrototype1.Contracts;
using ApoUtilityPrototype1.DI;
using ApoUtilityPrototype1.DomainModels;

namespace ApoUtilityPrototype1.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class LoginService : ILoginService
    {
        private readonly ILoginBll _bll;

        public LoginService()
        {
            _bll = DependencyResolver.ResolveBll<ILoginBll>();
        }

        public LoginService(ILoginBll bll)
        {
            _bll = bll;
        }

        public bool IsAuthenticUser(UserAccount user)
        {
            return _bll.IsAuthenticUser(user);
        }

        public bool CreateUser(UserAccount user)
        {
            return _bll.CreateUser(user);
        }
    }
}
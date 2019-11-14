using ApoUtilityPrototype1.Contracts;
using ApoUtilityPrototype1.DomainModels;

namespace ApoUtilityPrototype1.Bll
{
    public class LoginBll : ILoginBll
    {
        private readonly ILoginDal _dal;

        public LoginBll(ILoginDal dal)
        {
            _dal = dal;
        }

        public bool IsAuthenticUser(UserAccount user)
        {
            return _dal.IsAuthenticUser(user);
        }

        public bool CreateUser(UserAccount user)
        {
            return _dal.CreateUser(user);
        }
    }
}
using ApoUtilityPrototype1.Contracts;
using ApoUtilityPrototype1.DomainModels;
using System;
using System.Linq;

namespace ApoUtilityPrototype1.Dal
{
    public class LoginDal : ILoginDal
    {
        public bool IsAuthenticUser(UserAccount user)
        {
            using (var context = new ApoUtilityDbContext())
            {
                UserAccount userAccount = (from u in context.Account
                                           where u.Name == user.Name
                                                 && u.Password == user.Password
                                           select u).SingleOrDefault();

                return (userAccount != null);
            }
        }

        public bool CreateUser(UserAccount user)
        {
            using (var context = new ApoUtilityDbContext())
            {
                try
                {
                    UserAccount newUser = context.Account.Add(user);
                    context.SaveChanges();
                    return newUser != null;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
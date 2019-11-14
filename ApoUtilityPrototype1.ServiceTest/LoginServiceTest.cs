using ApoUtilityPrototype1.Contracts;
using ApoUtilityPrototype1.DomainModels;
using ApoUtilityPrototype1.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ApoUtilityPrototype1.ServiceTest
{
    [TestClass]
    public class LoginServiceTest
    {
        private Mock<ILoginBll> _bllMock;
        private ILoginService _loginService;

        [TestInitialize]
        public void Setup()
        {
            _bllMock = new Mock<ILoginBll>();
            _loginService = new LoginService(_bllMock.Object);
        }

        [TestMethod]
        public void Login_Success_Test()
        {
            var userAccount = new UserAccount
                {
                    UserId = 1,
                    Name = "admin",
                    Password = "admin"
                };
            _bllMock.Setup(b => b.IsAuthenticUser(userAccount)).Returns(true);

            bool isValidUser = _loginService.IsAuthenticUser(userAccount);

            Assert.IsTrue(isValidUser);
        }

        [TestMethod]
        public void Login_Fail_Test()
        {
            var userAccount = new UserAccount
                {
                    UserId = 1,
                    Name = "jon",
                    Password = "admin"
                };
            _bllMock.Setup(b => b.IsAuthenticUser(userAccount)).Returns(false);

            bool isValidUser = _loginService.IsAuthenticUser(userAccount);

            Assert.IsFalse(isValidUser);
        }

        [TestMethod]
        public void CreateUser_Call_Successfully()
        {
            var newUserAccount = new UserAccount
            {
                UserId = 1,
                Name = "jon",
                Password = "admin"
            };
            _bllMock.Setup(b => b.CreateUser(newUserAccount)).Returns(true);

            bool isCreateUserSuccessful = _loginService.CreateUser(newUserAccount);

            Assert.IsTrue(isCreateUserSuccessful);
        }
    }
}

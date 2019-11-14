using ApoUtilityPrototype1.Bll;
using ApoUtilityPrototype1.Contracts;
using ApoUtilityPrototype1.DomainModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ApoUtilityPrototype1.BllTest
{
    [TestClass]
    public class LoginBllTest
    {
        private Mock<ILoginDal> _dalMock;
        private ILoginBll _loginService;

        [TestInitialize]
        public void Setup()
        {
            _dalMock = new Mock<ILoginDal>();
            _loginService = new LoginBll(_dalMock.Object);
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
            _dalMock.Setup(b => b.IsAuthenticUser(userAccount)).Returns(true);

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
                Password = "doe"
            };
            _dalMock.Setup(b => b.IsAuthenticUser(userAccount)).Returns(false);

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
            _dalMock.Setup(b => b.CreateUser(newUserAccount)).Returns(true);

            bool isCreateUserSuccessful = _loginService.CreateUser(newUserAccount);

            Assert.IsTrue(isCreateUserSuccessful);
        }
    }
}

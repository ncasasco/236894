using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Test
{
    [TestClass]
    public class CredentialsManagerTests
    {
        private User someUser;
        private User simpleUser;
        private UserRepo usersRepo;

        private readonly DateTime May18th1998 = new DateTime(1998, 5, 18);

        [TestInitialize]
        public void Setup()
        {
            usersRepo = new UserRepo();
            someUser = new User()
            {
                Username = "Nicoo",
                Password = "Password9",
            };
            simpleUser = new User()
            {
                Username = "Ejemplo",
                Password = "Somepassword0",
            };
        }

        [TestMethod]
        public void ConstructorWithParametersTest()
        {
            var credentialsManager = new CredentialsManager(usersRepo, someUser);
            Assert.IsNotNull(credentialsManager);
        }

        [TestMethod]
        public void LoginTest()
        {
            var credentialsManager = new CredentialsManager(usersRepo, someUser);
            Credentials credentials = new Credentials()
            {
                Username = someUser.Username,
                Password = someUser.Password
            };

            credentialsManager.Login(credentials);

            Assert.IsTrue(credentialsManager.IsLogged);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Invalid username or password")]
        public void InvalidPasswordLoginTest()
        {
            var credentialsManager = new CredentialsManager(usersRepo, someUser);
            Credentials credentials = new Credentials()
            {
                Username = someUser.Username,
                Password = "inv"
            };

            credentialsManager.Login(credentials);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Invalid username or password")]
        public void InvalidUsernameLoginTest()
        {
            var credentialsManager = new CredentialsManager(usersRepo, someUser);
            Credentials credentials = new Credentials()
            {
                Username = "in",
                Password = someUser.Password
            };

            credentialsManager.Login(credentials);
        }

        [TestMethod]
        public void HashedPasswordTest()
        {
            var credentialsManager = new CredentialsManager(usersRepo, someUser);

            var storedUser = usersRepo.Get(someUser.Username);

            Assert.AreNotEqual(storedUser.Password, someUser.Password);
        }

        [TestMethod]
        public void RegisterNewUserTest()
        {
            var credentialsManager = new CredentialsManager(usersRepo, someUser);
            Credentials credentials = new Credentials()
            {
                Username = someUser.Username,
                Password = someUser.Password
            };
            credentialsManager.Login(credentials);

            credentialsManager.Register(simpleUser);

            credentialsManager.Logout();
            Credentials newUserCredentials = new Credentials()
            {
                Username = simpleUser.Username,
                Password = simpleUser.Password
            };
            credentialsManager.Login(newUserCredentials);

            Assert.IsTrue(credentialsManager.IsLogged);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Not logged in")]
        public void NotLoggedInTest()
        {
            var credentialsManager = new CredentialsManager(usersRepo, someUser);
            credentialsManager.Register(simpleUser);
        }

    }
}

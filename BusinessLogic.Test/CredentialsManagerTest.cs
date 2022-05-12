using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Test
{
    [TestClass]
    public class CredentialsManagerTests
    {
        private Producer admin;
        private Producer simpleProducer;
        private ProducerRepo producersRepo;

        private readonly DateTime May18th1998 = new DateTime(1998, 5, 18);

        [TestInitialize]
        public void Setup()
        {
            producersRepo = new ProducerRepo();
            admin = new Producer()
            {
                Mail = "adminnnnn",
                FirstName = "Johnnnnn",
                LastName = "Doeeeeee",
                Password = "password",
            };
            simpleProducer = new Producer()
            {
                Mail = "userrrrr",
                Password = "somepassword",
                FirstName = "Ryannnnn",
                LastName = "Jamesssss",
            };
        }

        [TestMethod]
        public void ConstructorWithParametersTest()
        {
            var credentialsManager = new CredentialsManager(producersRepo, admin);
            Assert.IsNotNull(credentialsManager);
        }

        [TestMethod]
        public void LoginTest()
        {
            var credentialsManager = new CredentialsManager(producersRepo, admin);
            Credentials credentials = new Credentials()
            {
                Mail = admin.Mail,
                Password = admin.Password
            };

            credentialsManager.Login(credentials);

            Assert.IsTrue(credentialsManager.IsLogged);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Invalid mail or password")]
        public void InvalidPasswordLoginTest()
        {
            var credentialsManager = new CredentialsManager(producersRepo, admin);
            Credentials credentials = new Credentials()
            {
                Mail = admin.Mail,
                Password = "invalid"
            };

            credentialsManager.Login(credentials);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Invalid mail or password")]
        public void InvalidMailLoginTest()
        {
            var credentialsManager = new CredentialsManager(producersRepo, admin);
            Credentials credentials = new Credentials()
            {
                Mail = "invalid",
                Password = admin.Password
            };

            credentialsManager.Login(credentials);
        }

        [TestMethod]
        public void HashedPasswordTest()
        {
            var credentialsManager = new CredentialsManager(producersRepo, admin);

            var storedProducer = producersRepo.Get(admin.Mail);

            Assert.AreNotEqual(storedProducer.Password, admin.Password);
        }

        [TestMethod]
        public void RegisterNewProducerTest()
        {
            var credentialsManager = new CredentialsManager(producersRepo, admin);
            Credentials credentials = new Credentials()
            {
                Mail = admin.Mail,
                Password = admin.Password
            };
            credentialsManager.Login(credentials);

            credentialsManager.Register(simpleProducer);

            credentialsManager.Logout();
            Credentials newProducerCredentials = new Credentials()
            {
                Mail = simpleProducer.Mail,
                Password = simpleProducer.Password
            };
            credentialsManager.Login(newProducerCredentials);

            Assert.IsTrue(credentialsManager.IsLogged);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Insufficient permissions")]
        public void InsufficientPermissionsTest()
        {
            var credentialsManager = new CredentialsManager(producersRepo, admin);
            Credentials credentials = new Credentials()
            {
                Mail = admin.Mail,
                Password = admin.Password
            };
            credentialsManager.Login(credentials);
            credentialsManager.Register(simpleProducer);
            credentialsManager.Logout();
            Credentials newProducerCredentials = new Credentials()
            {
                Mail = simpleProducer.Mail,
                Password = simpleProducer.Password
            };
            credentialsManager.Login(newProducerCredentials);
            credentialsManager.Register(simpleProducer);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Not logged in")]
        public void NotLoggedInTest()
        {
            var credentialsManager = new CredentialsManager(producersRepo, admin);
            credentialsManager.Register(simpleProducer);
        }

    }
}

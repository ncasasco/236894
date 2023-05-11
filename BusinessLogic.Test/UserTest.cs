using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace BusinessLogic.Test
{
    [TestClass]
    public class UserTest
    {
        private User NicoUser;
        private const string Nico = "Nicoooo";
        private const string Pass = "Password9";
        private const string TooShortUsername = "Na";
        private const string TooShortPassword = "Pass";
        private const string TooLongUsername = "ExtremelyLongUsername";
        private const string TooLongPassword = "ExtremelyLongLoongPassword";
        private readonly DateTime May18th1998 = new DateTime(1998, 5, 18);

        [TestInitialize]
        public void Initialize()
        {
            NicoUser = new User()
            {
                Username = Nico,
                Password = Pass,
                RegistrationDate = May18th1998,
            };
        }

        [TestMethod]
        public void ConstructorTest()
        {
            User User = new User();

            Assert.IsNotNull(User);
        }

        [TestMethod]
        public void setUsernameTest()
        {
            NicoUser.Username = Nico;
            Assert.AreEqual(Nico, NicoUser.Username);
        }

        [TestMethod]
        public void UsernameNotNullTest()
        {
            NicoUser.Username = null;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Username length must be between 3 and 20 characters")]
        public void UsernameMaxLengthTest()
        {
            NicoUser.Username = TooLongUsername;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Username length must be between 3 and 20 characters")]
        public void UsernameMinLengthTest()
        {
            NicoUser.Username = TooShortUsername;
        }

        [TestMethod]
        public void setPasswordTest()
        {
            NicoUser.Password = Pass;
            Assert.AreEqual(Pass, NicoUser.Password);
        }

        [TestMethod]
        public void PasswordNotNullTest()
        {
            NicoUser.Password = null;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Password length must be between 5 and 25 characters")]
        public void PasswordMaxLengthTest()
        {
            NicoUser.Password = TooLongPassword;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Username length must be between 5 and 25 characters")]
        public void PasswordMinLengthTest()
        {
            NicoUser.Password = TooShortPassword;

        }

        [TestMethod]
        public void setRegistrationDateTest()
        {
            NicoUser.RegistrationDate = May18th1998;
            Assert.AreEqual(May18th1998, NicoUser.RegistrationDate);
        }
    }
}
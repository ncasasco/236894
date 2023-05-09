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
        private const string RandomUser = "Randomuserrrr";
        private const string TooShortUsername = "Na";
        private const string TooLongUsername = "ExtremelyLongUsername";

        [TestInitialize]
        public void Initialize()
        {
            NicoUser = new User()
            {
                Username = Nico,
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
        [ExpectedException(typeof(BusinessLogicException), "Username length must be between 3 and 20")]
        public void UsernameMaxLengthTest()
        {
            NicoUser.Username = TooLongUsername;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Username length must be between 3 and 20")]
        public void UsernameMinLengthTest()
        {
            NicoUser.Username = TooShortUsername;
        }

        private static string GenerateString(string text, int length)
        {
            string tooLongPath = "";
            while (tooLongPath.Length < length)
                tooLongPath += text;
            return tooLongPath;
        }
    }
}


using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BusinessLogic.Test
{
    [TestClass]
    public class ProducerTest
    {
        private Producer johnDoeProducer;
        private const string John = "Johnnnnnn";
        private const string Doe = "Doe";
        private const string johndoe25 = "johndoeeee";

        private const string tooShortPassword = "Matias1";
        private const string TooLongName = "ExtremelyLongLongLongNameAndAlsoExtremelyLongLongLongLastName";

        [TestInitialize]
        public void Initialaze()
        {
            johnDoeProducer = new Producer()
            {
                FirstName = John,
                LastName = Doe,
                Mail = johndoe25,
            };
        }

        [TestMethod]
        public void ConstructorTest()
        {
            Producer Producer = new Producer();

            Assert.IsNotNull(Producer);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Producer name length must be between 8 and 30")]
        public void MailMaxLengthTest()
        {
            johnDoeProducer.Mail = TooLongName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Producer name length must be between 8 and 30")]
        public void MailMinLengthTest()
        {
            johnDoeProducer.Mail = "";
        }

        [TestMethod]
        public void MailNotNullTest()
        {
            johnDoeProducer.Mail = null;
        }

        [TestMethod]
        public void setMailTest()
        {
            johnDoeProducer.Mail = johndoe25;
            Assert.AreEqual(johndoe25, johnDoeProducer.Mail);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "First name length must be between 2 and 30")]
        public void FirstNameMaxLengthTest()
        {
            johnDoeProducer.FirstName = TooLongName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "First name length must be between 2 and 30")]
        public void FirstNameMinLengthTest()
        {
            johnDoeProducer.FirstName = "";
        }

        [TestMethod]
        public void setFirstNameTest()
        {
            johnDoeProducer.FirstName = John;
            Assert.AreEqual(John, johnDoeProducer.FirstName);
        }

        [TestMethod]
        public void FirstNameNotNullTest()
        {
            johnDoeProducer.FirstName = null;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Last name length must be between 2 and 60")]
        public void LastNameMaxLengthTest()
        {
            johnDoeProducer.LastName = TooLongName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Last name length must be between 2 and 60")]
        public void LastNameMinLengthTest()
        {
            johnDoeProducer.LastName = "";
        }

        [TestMethod]
        public void LastNameNotNullTest()
        {
            johnDoeProducer.LastName = null;
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

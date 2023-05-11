using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BusinessLogic;

namespace BusinessLogic.Test
{

    [TestClass]
    public class Vector3DTest
    {
        private Vector3D vector3D;
        private const double GREEN = 10;
        private const double BLUE = 20;
        private const double RED = 30;
        private const int MAX_PERCENTAGE = 100;
        private const int MIN_PERCENTAGE = 0;
        private const int BIGGER_THAN_MAX_PERCENTAGE = 120 ;

        [TestInitialize]
        public void Initialize()
        {
            Vector3D vector3D = new Vector3D()
            {
                GreenPercentage = GREEN,
                BluePercentage = BLUE,
                RedPercentage = RED
            };
        }
               
        [TestMethod]
        public void ConstructorTest()
        {
            vector3D = new Vector3D();
            Assert.IsNotNull(vector3D);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Red Percentage length must be between 0 and 100")]
        public void RedPercentageMaxLengthTest()
        {

            vector3D.RedPercentage = BIGGER_THAN_MAX_PERCENTAGE;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Red Percentage length must be between 0 and 100")]
        public void RedPercentageMinLengthTest()
        {
            vector3D.RedPercentage = -1;
        }

        [TestMethod]
        public void setRedPercentageTest()
        {
            vector3D.RedPercentage = RED;
            Assert.AreEqual(RED, vector3D.RedPercentage);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Blue Percentage length must be between 0 and 100")]
        public void BluePercentageMaxLengthTest()
        {

            vector3D.BluePercentage = BIGGER_THAN_MAX_PERCENTAGE;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Blue Percentage length must be between 0 and 100")]
        public void BluePercentageMinLengthTest()
        {
            vector3D.BluePercentage = -1;
        }

        [TestMethod]
        public void SetBluePercentageTest()
        {
            vector3D.BluePercentage = BLUE;
            Assert.AreEqual(BLUE, vector3D.BluePercentage);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Green Percentage length must be between 0 and 100")]
        public void GreenPercentageMaxLengthTest()
        {
            vector3D.GreenPercentage = BIGGER_THAN_MAX_PERCENTAGE;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Green Percentage length must be between 0 and 100")]
        public void GreenPercentageMinLengthTest()
        {
            vector3D.GreenPercentage = -1;
        }

        [TestMethod]
        public void SetGreenPercentageTest()
        {
            vector3D.GreenPercentage = GREEN;
            Assert.AreEqual(GREEN, vector3D.GreenPercentage);
        }

        [TestMethod]
        public void RojoTest()
        {
            const double RESULTADO_RED_EXPECTED = 10; 
            vector3D.RedPercentage = RED;
            double resultado = vector3D.Red();
            Assert.AreEqual(RESULTADO_RED_EXPECTED, resultado);

        }

        [TestMethod]
        public void VerdeTest()
        {
            const double RESULTADO_GREEN_EXPECTED = 10;
            vector3D.GreenPercentage = GREEN;
            double resultado = vector3D.Green();
            Assert.AreEqual(RESULTADO_GREEN_EXPECTED, resultado);

        }


        [TestMethod]
        public void AzulTest()
        {
            const double RESULTADO_BLUE_EXPECTED = 10;
            vector3D.BluePercentage = BLUE;
            double resultado = vector3D.Green();
            Assert.AreEqual(RESULTADO_BLUE_EXPECTED, resultado);

        }

        [TestMethod]               
        public void AddVector()
        {
            Vector3D vector3DResultado = new Vector3D();
            Vector3D vector3DIn = new Vector3D();

            vector3DIn.RedPercentage = RED;
            vector3DIn.BluePercentage = BLUE;
            vector3DIn.GreenPercentage = GREEN;

            vector3DResultado = vector3D.AddVector( vector3DIn);
           
           // Assert.AreEqual(RESULTADO_BLUE_EXPECTED, resultado);
           
        }
    }
}

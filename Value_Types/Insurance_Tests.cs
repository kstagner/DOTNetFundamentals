using System;
using Car_Insurance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Value_Types
{
    [TestClass]
    public class Insurance_Tests
    {
        [TestMethod]
        public void Car_Insurance_SetProperties_ShouldBeCorrectValue()
        {
            //Arrange
            Car carOne = new Car();
            carOne.Brand = "Chrystler";
            carOne.Model = "Patriot";
            carOne.Make = "Jeep";
            carOne.Year = 2017;
            carOne.Color = "Darkred";
            carOne.Wheels = 4;
            carOne.HadAccident = true;
            carOne.Owners = 1;
            
            //Act
            string actualOne = carOne.Brand;
            string expectedOne = "Chrystler";

            string actualTwo = carOne.Model;
            string expectedTwo = "Patriot";

            string actualThree = carOne.Make;
            string expectedThree = "Jeep";

            int actualFour = carOne.Year;
            int expectedFour = 2017;

            string actualFive = carOne.Color;
            string expectedFive = "Darkred";

            int actualSix = carOne.Wheels;
            int expectedSix = 4;

            bool actualSeven = carOne.HadAccident;
            bool expectedSeven = true;

            int actualEight = carOne.Owners;
            int expectedEight = 1;


            //Assert
            Assert.AreEqual(expectedOne, actualOne);
            Assert.AreEqual(expectedTwo, actualTwo);
            Assert.AreEqual(expectedThree, actualThree);
            Assert.AreEqual(expectedFour, actualFour);
            Assert.AreEqual(expectedFive, actualFive);
            Assert.AreEqual(expectedSix, actualSix);
            Assert.AreEqual(expectedSeven, actualSeven);
            Assert.AreEqual(expectedEight, actualEight);

        }


        [TestMethod]
        public void CarInsurance_SetProperties_ShouldBeCorrectValue()
        {
            //Arrange
            Car vehicletype = new Car("Chrystler", "Patriot", 2017, "Jeep", "Darkred", 4, true, 1);
            //Act
            string actual = vehicletype.Brand;
            string expected = "Chrystler";

            string actualOne = vehicletype.Model;
            string expectedOne = "Patriot";

            string actualTwo = vehicletype.Make;
            string expectedTwo = "Jeep";

            int actualThree = vehicletype.Year;
            int expectedThree = 2017;

            string actualFour = vehicletype.Color;
            string expectedFour = "Darkred";

            int actualFive = vehicletype.Wheels;
            int expectedFive = 4;

            bool actualSix = vehicletype.HadAccident;
            bool expectedSix = true;

            int actualSeven = vehicletype.Owners;
            int expectedSeven = 1;



            
        }
        
    }
}

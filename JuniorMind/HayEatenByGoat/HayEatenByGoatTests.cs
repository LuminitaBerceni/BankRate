using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HayEatenByGoat
{
    [TestClass]
    public class HayEatenByGoatTests
    {
        [TestMethod]
        public void HayForFiveGoatsInTwoDays()
        {
            float kilogramsOfHay = CalculateHayEatenByGoat(1, 2, 10, 5, 2);
            Assert.AreEqual( 50, kilogramsOfHay);
        }

        [TestMethod]
        public void HayForTenGoatsInSevenDays()
        {
            float kilogramsOfHay = CalculateHayEatenByGoat(5, 3, 105, 10, 7);
            Assert.AreEqual(490, kilogramsOfHay);
        }

        float CalculateHayEatenByGoat(int initialNumberOfGoats, int initialNumberOfDays, float initialKilogramsOfHay, int numberOfGoats, int numberOfDays)
        {
            return (numberOfGoats * numberOfDays * initialKilogramsOfHay) / (initialNumberOfGoats * initialNumberOfDays);
        }
    }
}

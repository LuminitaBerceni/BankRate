using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RedMushrooms
{
    [TestClass]
    public class RedMushroomsTests
    {
        [TestMethod]
        public void ThreeMushrooms()
        {
            int redMushrooms = CalculateNumberOfRedMushrooms(3, 2);
            Assert.AreEqual(2, redMushrooms);
        }

        [TestMethod]
        public void TenMushrooms()
        {
            int redMushrooms = CalculateNumberOfRedMushrooms(10, 4);
            Assert.AreEqual(8, redMushrooms);
        }

        int CalculateNumberOfRedMushrooms(int totalNumberOfMushrooms, int multiplierOfRedMushrooms)
        {
            return multiplierOfRedMushrooms * totalNumberOfMushrooms / (multiplierOfRedMushrooms + 1);
        }
    }
}

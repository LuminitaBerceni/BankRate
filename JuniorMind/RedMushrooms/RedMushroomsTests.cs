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

        int CalculateNumberOfRedMushrooms(int totalNumberOfMushrooms, int multiplierOfRedMushrooms)
        {
            return 0;
        }
    }
}

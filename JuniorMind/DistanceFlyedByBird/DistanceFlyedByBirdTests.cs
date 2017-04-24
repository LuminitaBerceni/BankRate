using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DistanceFlyedByBird
{
    [TestClass]
    public class DistanceFlyedByBirdTests
    {
        [TestMethod]
        public void DistanceFor30Speed()
        {
            int distance = CalculateDistanceFlyedByBird(120,30);
            Assert.AreEqual(60,distance);
        }

        int CalculateDistanceFlyedByBird(int initialDistance, int trainSpeed)
        {
            return 0;
        }
    }
}

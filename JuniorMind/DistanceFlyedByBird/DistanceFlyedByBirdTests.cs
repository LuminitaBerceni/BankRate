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
            int remainingDistance = initialDistance / 2;
            int birdSpeed = trainSpeed * 2;
            int time = remainingDistance / (trainSpeed * 2);
            return time * birdSpeed;
        }
    }
}

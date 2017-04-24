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
            float distance = CalculateDistanceFlyedByBird(120,30);
            Assert.AreEqual(60,distance);
        }

        [TestMethod]
        public void DistanceFor50Speed()
        {
            float distance = CalculateDistanceFlyedByBird(100, 50);
            Assert.AreEqual(50, distance);
        }

        float CalculateDistanceFlyedByBird(int initialDistance, int trainSpeed)
        {
            int remainingDistance = initialDistance / 2;
            int birdSpeed = trainSpeed * 2;
            float time = (float)remainingDistance / (trainSpeed * 2);
            return time * birdSpeed ;
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cyclometer
{
    [TestClass]
    public class CyclometerTests
    {
        [TestMethod]
        public void TotalDistanceForOneCyclist()

        {
            var cyclist = new Cyclist("Florin", 20, new Cyclometer[] { new Cyclometer(2, 1), new Cyclometer(3, 2), new Cyclometer(4, 3) });
            Assert.AreEqual(565.2, cyclist.CalculateTotalDistance());
        }

        [TestMethod]
        public void TotalDistanceForAllCyclists()

        {
            Cyclist[] cyclists = new Cyclist[] {new Cyclist("Florin", 20, new Cyclometer[] { new Cyclometer(2, 1), new Cyclometer(3, 2), new Cyclometer(4, 3) }),
                                               new Cyclist("George", 25, new Cyclometer[] { new Cyclometer(3, 1), new Cyclometer(2, 2), new Cyclometer(2, 3) })};
            Assert.AreEqual(1114.7, CalculateTotalDistance(cyclists));
        }

        [TestMethod]
        public void GetMaximRotationForOneCyclist()

        {
            var cyclist = new Cyclist("Florin", 20, new Cyclometer[] { new Cyclometer(2, 1), new Cyclometer(3, 2), new Cyclometer(4, 3) });
            var result = cyclist.GetMaximRotation();
            Assert.AreEqual(4, result.rotations);
            Assert.AreEqual(3, result.second);
        }

        [TestMethod]
        public void GetFastestCyclist()

        {
            Cyclist[] cyclists = new Cyclist[] {new Cyclist("Florin", 20, new Cyclometer[] { new Cyclometer(2, 1), new Cyclometer(3, 2), new Cyclometer(4, 3) }),
                                                new Cyclist("George", 25, new Cyclometer[] { new Cyclometer(3, 1), new Cyclometer(2, 2), new Cyclometer(2, 3) }),
                                                new Cyclist("Alex", 22, new Cyclometer[] { new Cyclometer(5, 1), new Cyclometer(4, 2), new Cyclometer(4, 3) })};
            var result = FindFastestCyclist(cyclists);
            Assert.AreEqual("Alex", result.name);
            Assert.AreEqual(1, result.second);
        }

        [TestMethod]
        public void GetAverageSpeedForOneCyclist()

        {
            var cyclist = new Cyclist("Florin", 20, new Cyclometer[] { new Cyclometer(2, 1), new Cyclometer(3, 2), new Cyclometer(4, 3) });
            var result = cyclist.CalculateAverageSpeed();
            Assert.AreEqual(188.4, result);
        }

        struct Cyclist
        {
            public string name;
            public double wheelDiameter;
            public Cyclometer[] records;

            public Cyclist(string name, double wheelDiameter, Cyclometer[] records)
            {
                this.name = name;
                this.wheelDiameter = wheelDiameter;
                this.records = records;
            }

            public double CalculateTotalDistance()
            {
                double totalDistance = 0;
                for (int i = 0; i < records.Length; i++)
                {
                    totalDistance += 3.14 * wheelDiameter * records[i].rotations;
                }
                return totalDistance;
            }

            public Cyclometer GetMaximRotation()
            {
                Cyclometer maxRotations = new Cyclometer(records[0].rotations, records[0].second);
                for (int i = 0; i < records.Length; i++)
                {
                    if (records[i].rotations > maxRotations.rotations)
                        maxRotations = new Cyclometer(records[i].rotations, records[i].second);
                }
                return maxRotations;
            }

            public double CalculateAverageSpeed()
            {
                int totalTime = records[records.Length - 1].second;
                return CalculateTotalDistance() / totalTime;
            }

        }

        struct Cyclometer
        {
            public int rotations;
            public int second;

            public Cyclometer(int rotations, int seconds)
            {
                this.rotations = rotations;
                this.second = seconds;
            }
        }

        struct ResultedCyclist
        {
            public string name;
            public int second;

            public ResultedCyclist(string name, int second)
            {
                this.name = name;
                this.second = second;
            }
        }

        double CalculateTotalDistance(Cyclist[] cyclists)
        {
            double totalDistance = 0;
            for (int i = 0; i < cyclists.Length; i++)
            {
                totalDistance += cyclists[i].CalculateTotalDistance();
            }
            return totalDistance;
        }

        ResultedCyclist FindFastestCyclist(Cyclist[] cyclists)
        {
            ResultedCyclist result = new ResultedCyclist("", 0);
            double maximumDistance = 3.14 * cyclists[0].wheelDiameter * cyclists[0].GetMaximRotation().rotations;
            int second = cyclists[0].GetMaximRotation().second;

            for (int i = 0; i < cyclists.Length; i++)
            {
                double distance = 3.14 * cyclists[i].wheelDiameter * cyclists[i].GetMaximRotation().rotations;
                if (distance > maximumDistance)
                {
                    maximumDistance = distance;
                    result.name = cyclists[i].name;
                    result.second = cyclists[i].GetMaximRotation().second;
                }
            }
            return result;
        }

        /*double CalculateAverageSpeed(Cyclist cyclist)
        {
            double distance = CalculateTotalDistanceOfOneCyclist(cyclist);
            double averageSpeed = 0;
            int totalTime = cyclist.records[cyclist.records.Length - 1].second;
            averageSpeed += distance / totalTime;
            return averageSpeed;
        }

        double CalculateBestAverageSpeed(Cyclist[] cyclists)
        {
            double bestAverageSpeed = CalculateAverageSpeed(cyclists[0]);
            for (int i = 0; i < cyclists.Length; i++)
            {
                double speed = CalculateAverageSpeed(cyclists[i]);
                if (speed > bestAverageSpeed)
                    bestAverageSpeed = speed;
            }
            return bestAverageSpeed;
        }*/

    }
}

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
    }
}

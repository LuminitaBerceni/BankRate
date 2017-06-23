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
            Assert.AreEqual(565.2, CalculateTotalDistanceForOneCyclist(cyclist));
        }

        [TestMethod]
        public void TotalDistanceForAllCyclists()

        {
            Cyclist[] cyclists = new Cyclist[] {new Cyclist("Florin", 20, new Cyclometer[] { new Cyclometer(2, 1), new Cyclometer(3, 2), new Cyclometer(4, 3) }),
                                               new Cyclist("George", 25, new Cyclometer[] { new Cyclometer(3, 1), new Cyclometer(2, 2), new Cyclometer(2, 3) })};
            Assert.AreEqual(1114.7, CalculateTotalDistance(cyclists));
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

        }

        struct Cyclometer
        {
            public int rotations;
            public int seconds;

            public Cyclometer(int rotations, int seconds)
            {
                this.rotations = rotations;
                this.seconds = seconds;
            }
        }

        double CalculateTotalDistanceForOneCyclist(Cyclist cyclist)
        {
            double totalDistance = 0;
            for (int i = 0; i < cyclist.records.Length; i++)
            {
                totalDistance += 3.14 * cyclist.wheelDiameter * cyclist.records[i].rotations;
            }
            return totalDistance;
        }

        double CalculateTotalDistance(Cyclist[] cyclists)
        {
            double totalDistance = 0;
            for (int i = 0; i < cyclists.Length; i++)
            {
                totalDistance += CalculateTotalDistanceForOneCyclist(cyclists[i]);
            }
            return totalDistance;
        }
    }
}

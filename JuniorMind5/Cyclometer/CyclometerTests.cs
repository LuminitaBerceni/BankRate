using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cyclometer
{
    [TestClass]
    public class CyclometerTests
    {
        [TestMethod]
        public void TestMethod1()
        {
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

            public Cyclometer(string rotations, double seconds)
            {
                this.rotations = rotations;
                this.seconds = seconds;
            }
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hanoi_Towers
{
    [TestClass]
    public class HanoiTowersTests
    {
        [TestMethod]
        public void MovesForTwoDisks()
        {
            Assert.AreEqual("SM SD MD", HanoiTowers(2, 'S', 'M', 'D'));
        }

        string HanoiTowers(int disks, char leftTower, char middleTower, char rightTower)
        {
            return "";
        }
    }
}

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
            string moves = string.Empty;
            if (disks == 1)
                return Convert.ToString(leftTower) + Convert.ToString(rightTower);
            moves = moves + HanoiTowers(disks - 1, leftTower, rightTower, middleTower);
            moves = moves + " " + HanoiTowers(1, leftTower, middleTower, rightTower);
            moves = moves + " " + HanoiTowers(disks - 1, middleTower, leftTower, rightTower);
            return moves;
        }
    }
}

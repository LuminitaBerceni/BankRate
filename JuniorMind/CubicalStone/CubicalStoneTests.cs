using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CubicalStone
{
    [TestClass]
    public class CubicalStoneTests
    {
        [TestMethod]
        public void CubicalStoneFor6x6Square()
        {
            double cubicalStone = CalculateCubicalStone(6, 6, 4);
            Assert.AreEqual(4, cubicalStone);
        }

        [TestMethod]
        public void CubicalStoneFor8x4Square()
        {
            double cubicalStone = CalculateCubicalStone(8, 4, 3);
            Assert.AreEqual(6, cubicalStone);
        }

        double CalculateCubicalStone(double squareLenght, double squareWidth, int cubicalStoneSide)
        {    
            return Math.Ceiling(squareLenght/cubicalStoneSide) * Math.Ceiling(squareWidth / cubicalStoneSide);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SquaresInChessTable
{
    [TestClass]
    public class SquaresInChessTableTests
    {
        [TestMethod]
        public void SquaresOnOneByOneTable()
        {
            int squares = CalculateSquaresInChessTable(1);
            Assert.AreEqual(1, squares);
        }

        [TestMethod]
        public void SquaresOnEightByEightTable()
        {
            int squares = CalculateSquaresInChessTable(8);
            Assert.AreEqual(204, squares);
        }

        int CalculateSquaresInChessTable (int number)
        {
            int totalSquares = 0;
            for (int i = 1; i <= number; i++)
                totalSquares += i * i;
            return totalSquares;
        }
    }
}

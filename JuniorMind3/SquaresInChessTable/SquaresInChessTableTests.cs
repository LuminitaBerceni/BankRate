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

        int CalculateSquaresInChessTable (int number)
        {
            return 0;
        }
    }
}

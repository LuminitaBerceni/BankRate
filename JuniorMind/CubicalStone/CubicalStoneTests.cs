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
            int cubicalStone = CalculateCubicalStone(6, 6, 4);
            Assert.AreEqual(4, cubicalStone);
        }

        int CalculateCubicalStone(int squareLenght, int squareWidth, int cubicalStoneSide)
        {
            int cubicalStoneForLehght = squareLenght / cubicalStoneSide;

            if (squareLenght % cubicalStoneSide != 0)
                cubicalStoneForLehght = cubicalStoneForLehght + 1;

            int cubicalStoneForWidth = squareWidth / cubicalStoneSide;

            if (squareWidth % cubicalStoneSide != 0)
                cubicalStoneForWidth = cubicalStoneForWidth + 1;
                
            return cubicalStoneForLehght * cubicalStoneForWidth;
        }
    }
}

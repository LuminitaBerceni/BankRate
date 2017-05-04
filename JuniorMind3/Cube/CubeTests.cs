using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cube
{
    [TestClass]
    public class CubeTests
    {
        [TestMethod]
        public void GetFirstCube()
        {
            int number = GetCube(1);
            Assert.AreEqual(192, number);
        }


        [TestMethod]
        public void GetSecondCube()
        {
            int number = GetCube(2);
            Assert.AreEqual(442, number);
        }

        int GetCube(int k)
        {
            int count = 0;
            int number = 191;
            int cube = 1;
            while (count < k)
            {
                number++;
                cube = (int)Math.Pow(number, 3);
                if (cube % 1000 == 888)
                    count++;
            }

            return number;
        }
    }
}

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

        int GetCube(int k)
        {
            int count = 0;
            int number = 1;
            int cube = 1;
            while (count < k)
            {
                number++;
                cube = number * number * number;
                if (cube % 1000 == 888)
                    count++;
            }

            return number;
        }
    }
}

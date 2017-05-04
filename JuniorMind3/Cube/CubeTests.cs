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
            return 0;
        }
    }
}

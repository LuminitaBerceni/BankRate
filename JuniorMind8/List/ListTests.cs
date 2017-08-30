using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace List
{
    [TestClass]
    public class ListTests
    {
        [TestMethod]
        public void AddTest()
        {
            var list = new List<int> { 1, 2, 3, 4 };
            list.Add(5);
            Assert.AreEqual(5, list[4]);
        }

        [TestMethod]
        public void AddStringTest()
        {
            var list = new List<string> { "a", "b" };
            list.Add("c");
            Assert.AreEqual("c", list[2]);
        }
    }
}

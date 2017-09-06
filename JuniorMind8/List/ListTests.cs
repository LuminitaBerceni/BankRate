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

        [TestMethod]
        public void CountTest()
        {
            var list = new List<int> { 1, 2, 3, 4 };
            Assert.AreEqual(4, list.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CountTestArgumentNull()
        {
            var list = new List<string> { };

            var count = list.Count;
        }

        [TestMethod]
        public void CountStringTest()
        {
            var list = new List<string> { "a", "b" };
            Assert.AreEqual(2, list.Count);
        }

        [TestMethod]
        public void ClearTest()
        {
            var list = new List<string> { "a", "b" };
            list.Clear();
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void ContainsTest()
        {
            var list = new List<string> { "a", "b" };
            Assert.IsTrue(list.Contains("b"));
        }

        [TestMethod]
        public void IndexOfTest()
        {
            var list = new List<string> { "a", "b" };
            Assert.AreEqual(1, list.IndexOf("b"));
        }
    }
}

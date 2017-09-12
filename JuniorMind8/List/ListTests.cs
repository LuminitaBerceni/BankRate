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
        [ExpectedException(typeof(ArgumentNullException))]
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

        [TestMethod]
        public void CopyToTest()
        {
            var integersList = new List<int>() { 2, 3};
            int[] array = new int[] { 1, 7, 6, 4, 5 };
            integersList.CopyTo(array, 1);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, array);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CopyToArgumentNullExceptionTest()
        {
            var integersList = new List<int>() { 2, 3 };
            int[] array = new int[] {};
            integersList.CopyTo(array, 1);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, array);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CopyToArgumentOutOfRangeExceptionTest()
        {
            var integersList = new List<int>() { 2, 3 };
            int[] array = new int[] { 1, 7, 6, 4, 5 };
            integersList.CopyTo(array, -1);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, array);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Copy_To_Argument_Exception()
        {
            var integersList = new List<int>() { 2, 3 };
            int[] array = new int[1];
            integersList.CopyTo(array, 0);
            CollectionAssert.AreEqual(new int[] { 2, 3}, array);
        }

        [TestMethod]
        public void InsertTest()
        {
            var list = new List<int> { 1, 3, 4 };
            list.Insert(1, 2);

            var b = list.GetEnumerator();
            b.MoveNext();
            b.MoveNext();
            Assert.AreEqual(2, b.Current);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InsertArgumentOutOfRangeExceptionTest()
        {
            var list = new List<int> { 1, 3, 4 };
            list.Insert(5, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InsertArgumentOutOfRangeExceptionTest2()
        {
            var list = new List<int> { 1, 3, 4 };
            list.Insert(-1, 0);
        }

        [TestMethod]
        public void RemoveAtTest()
        {
            var list = new List<int> { 1, 4, 2, 3 };
            list.RemoveAt(1);
            Assert.AreEqual(1, list.IndexOf(2));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveAtArgumentOutOfRangeExceptionTest()
        {
            var list = new List<int> { 1, 4, 2, 3 };
            list.RemoveAt(5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveAtArgumentOutOfRangeExceptionTest2()
        {
            var list = new List<int> { 1, 4, 2, 3 };
            list.RemoveAt(-1);
        }

        [TestMethod]
        public void RemoveTest()
        {
            var list = new List<int> { 1, 4, 2, 3 };

            list.Remove(1);

            Assert.IsFalse(list.Contains(1));
            Assert.AreEqual(0, list.IndexOf(4));
        }
    }
}

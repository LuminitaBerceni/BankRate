using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace LinkedList
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void AddTest()
        {
            var linkedList = new LinkedList<int> { 2, 3 };
            linkedList.Add(1);
            Assert.AreEqual(3, linkedList.Count);
        }

        [TestMethod]
        public void AddFirstTest()
        {
            var linkedList = new LinkedList<int> { 2, 3 };
            linkedList.AddFirst(1);
            Assert.IsTrue(linkedList.SequenceEqual(new LinkedList<int>() { 1, 2, 3}));
        }

        [TestMethod]
        public void AddLastTest()
        {
            var linkedList = new LinkedList<int> { 2, 3 };
            linkedList.AddLast(4);
            Assert.IsTrue(linkedList.SequenceEqual(new LinkedList<int>() { 2, 3, 4 }));
        }

        [TestMethod]
        public void RemoveFirstAppearanceTest()
        {
            var linkedList = new LinkedList<int> { 2, 1, 2, 3, 4 };
            linkedList.Remove(2);
            Assert.IsTrue(linkedList.SequenceEqual(new LinkedList<int>() { 1, 2, 3, 4 }));
        }

        [TestMethod]
        public void RemoveFirstNodeTest()
        {
            var linkedList = new LinkedList<int> { 5, 6, 7, 8 };
            linkedList.RemoveFirst();
            Assert.IsTrue(linkedList.SequenceEqual(new LinkedList<int> { 6, 7, 8 }));
        }

        [TestMethod]
        public void RemoveLastNodeTest()
        {
            var linkedList = new LinkedList<int> { 5, 6, 7, 8 };
            linkedList.RemoveLast();
            Assert.IsTrue(linkedList.SequenceEqual(new LinkedList<int> { 5, 6, 7 }));
        }

        [TestMethod]
        public void ClearTest()
        {
            var linkedList = new LinkedList<int> { 5, 6, 7, 8 };
            linkedList.Clear();
            Assert.AreEqual(0, linkedList.Count);
        }

        [TestMethod]
        public void ContainsTest()
        {
            var linkedList = new LinkedList<int> { 5, 6, 7, 8 };
            Assert.IsTrue(linkedList.Contains(7));
        }

        [TestMethod]
        public void FindNodeTest()
        {
            var linkedList = new LinkedList<int> { 1, 2, 3, 4 };
            Node<int> node = linkedList.Find(3);
            Assert.AreEqual(3, node.Data);
            Assert.AreEqual(null, linkedList.Find(10));
        }

        [TestMethod]
        public void CopyToTest()
        {
            var linkedList = new LinkedList<int> { 1, 6, 4 };
            int[] newArray = new int[9];
            int startIndex = 3;
            linkedList.CopyTo(newArray, startIndex);

            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 1, 6, 4, 0, 0, 0 }, newArray);
        }
    }
}

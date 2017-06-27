using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void FibonacciTest1()
        {
            Assert.AreEqual(1, Fibonacci(1));
        }

        int Fibonacci(int n)
        {
            return 0;
        }
    }
}

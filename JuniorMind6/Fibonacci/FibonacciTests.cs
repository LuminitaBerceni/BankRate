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

        [TestMethod]
        public void FibonacciTest2()
        {
            Assert.AreEqual(8, Fibonacci(6));
        }

        [TestMethod]
        public void FibonacciTest3()
        {
            Assert.AreEqual(610, Fibonacci(15));
        }

        int Fibonacci(int n)
        {
            int previous = 0;
            return Fibonacci(n, ref previous);
        }
        int Fibonacci(int n, ref int previous)
        {
            if (n < 2) return n;
            int beforePrevious = 0;
            previous = Fibonacci(n - 1, ref beforePrevious);
            return previous + beforePrevious;
        }
    }
}

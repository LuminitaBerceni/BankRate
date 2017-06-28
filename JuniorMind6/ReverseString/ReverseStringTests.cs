using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReverseString
{
    [TestClass]
    public class ReverseStringTests
    {
        [TestMethod]
        public void ReverseStringWith2Characters()
        {
            Assert.AreEqual("ba" , ReverseString("ab"));
        }

        string ReverseString (string initialString)
        {
            if (initialString.Length == 1)
                return initialString;
            return initialString.Substring(initialString.Length - 1) + ReverseString (initialString.Substring(0,initialString.Length - 1));
        }
    }
}

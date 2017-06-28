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
            return "";
        }
    }
}

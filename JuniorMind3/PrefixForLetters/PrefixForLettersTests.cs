using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrefixForLetters
{
    [TestClass]
    public class PrefixForLettersTests
    {
        [TestMethod]
        public void FindPrefixForShortString()
        {
            string prefix = FindPrefixLetters("ab", "aa");
            Assert.AreEqual("a", prefix);
        }

        string FindPrefixLetters (string firstString, string secondString)
        {
            return "";
        }
    }
}

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
            string prefix = "";
            int firstStringLength = firstString.Length;
            for (int i = 0; i <= firstStringLength; i++)
            {
                if (firstString[i] != secondString[i])
                    break;
                else
                    prefix = prefix + firstString[i];
            }

            return prefix;
        }
    }
}

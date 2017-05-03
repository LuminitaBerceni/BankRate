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

        [TestMethod]
        public void FindPrefixForLongString()
        {
            string prefix = FindPrefixLetters("aabbcdef", "aabccdef");
            Assert.AreEqual("aab", prefix);
        }

        [TestMethod]
        public void FindPrefixForStringWithDifferentLength()
        {
            string prefix = FindPrefixLetters("aa", "aab");
            Assert.AreEqual("aa", prefix);
        }

        string FindPrefixLetters (string firstString, string secondString)
        {
            string prefix = "";
            string smallerString = firstString.Length < secondString.Length ? firstString : secondString;
            int smallerStringLength = smallerString.Length;
            for (int i = 0; i < smallerStringLength; i++)
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

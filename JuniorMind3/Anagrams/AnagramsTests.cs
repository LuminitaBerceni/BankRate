using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagrams
{
    [TestClass]
    public class AnagramsTests
    {
        [TestMethod]
        public void CalculateAnagramsWithTwoDifferentLetters()
        {
            int anagrams = CalculateAnagrams("ab");
            Assert.AreEqual(2 , anagrams);

        }

        int CalculateAnagrams (string word)
        {
            return 0;
        }

    }
}

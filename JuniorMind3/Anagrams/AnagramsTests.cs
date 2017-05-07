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
            return CalculateFactorial(word.Length);
        }

        int CalculateFactorial(int number)
        {
            if (number == 1)
                return 1;
            else
                return number * CalculateFactorial(number - 1);

        }

    }
}

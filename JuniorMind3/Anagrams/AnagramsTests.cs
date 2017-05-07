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

        [TestMethod]
        public void CalculateAnagramsWithTwoIdenticalLetters()
        {
            int anagrams = CalculateAnagrams("aa");
            Assert.AreEqual(1, anagrams);
        }

        [TestMethod]
        public void CalculateAnagramsWithIdenticalLetters()
        {
            int anagrams = CalculateAnagrams("baba");
            Assert.AreEqual(6, anagrams);
        }

        int CalculateAnagrams (string word)
        {
            int factorialForRepetition = 1;
            for (int i = 'a'; i < 'z'; i++)
            {
                factorialForRepetition *= CalculateFactorial(CalculateNumberOfRepetition(word, (char)i));
            }

            return CalculateFactorial(word.Length) / factorialForRepetition;
        }

        int CalculateFactorial(int number)
        {
            int factorial = 1;
            for (int i = 2; i <= number; i++)
                factorial *= i;
            return factorial;
        }

        int CalculateNumberOfRepetition(string word, char letter)
        {
            int counter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (letter == word[i])
                    counter++;
            }
            return counter;
        }

    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Password
{
    [TestClass]
    public class PasswordTests
    {
        [TestMethod]
        public void PasswordWithSmallLetters()
        {
            string password = GenerateRandomLettersAndDigits(6, 'a', 'z');
            Assert.AreEqual(6, VerifySmallLetters(password, 'a', 'z'));
        }

        [TestMethod]
        public void PasswordWithSmallAndCapitalLetters()
        {
            string password = GenerateRandomLettersAndDigits(3, 'a', 'z') + GenerateRandomLettersAndDigits(3, 'A', 'Z');
            Assert.AreEqual(3, VerifySmallLetters(password, 'a', 'z'));
            Assert.AreEqual(3, VerifySmallLetters(password, 'A', 'Z'));
        }

        [TestMethod]
        public void PasswordWithSmallCapitalLettersAndDigits()
        {
            string password = GenerateRandomLettersAndDigits(2, 'a', 'z') + GenerateRandomLettersAndDigits(1, 'A', 'Z') + GenerateRandomLettersAndDigits(1,'0', '9');
            Assert.AreEqual(1, VerifySmallLetters(password, 'A', 'Z'));
            Assert.AreEqual(2, VerifySmallLetters(password, 'a', 'z'));
            Assert.AreEqual(1, VerifySmallLetters(password, '0', '9'));
        }

        struct Password
        {
            public int passwordLength;
            public int smallLetters;
            public int capitalLetters;
            public int digits;
            public int symbols;
            public bool exludeSimilarCharacters;
            public bool excludeAmbiguousCharacters;
            public Password(int passwordLength, int smallLetters, int capitalLetters, int digits, int symbols, bool exludeSimilarCharacters, bool excludeAmbiguousCharacters)
            {
                this.passwordLength = passwordLength;
                this.smallLetters = smallLetters;
                this.capitalLetters = capitalLetters;
                this.digits = digits;
                this.symbols = symbols;
                this.exludeSimilarCharacters = exludeSimilarCharacters;
                this.excludeAmbiguousCharacters = excludeAmbiguousCharacters;
            }
        }

        Random random = new Random();

        char GenerateRandomCharacter(char lowerLimit, char upperLimit)
        {
            return (char)(random.Next(lowerLimit, upperLimit + 1));
        }

        string GenerateRandomLettersAndDigits(int nrOfLetters, char lowerLimit, char upperLimit)
        {
            string password = "";
            for (int i = 0; i < nrOfLetters; i++)
            {
                password += GenerateRandomCharacter(lowerLimit, upperLimit);
            }
            return password;
        }

        int VerifySmallLetters(string password, char lowerLimit, char upperLimit)
        {
            int counter = 0;
            foreach (char c in password)
                if (lowerLimit <= c && c <= upperLimit)
                    counter++;
            return counter;
        }
    }
}

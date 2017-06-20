﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Password
{
    [TestClass]
    public class PasswordTests
    {
        [TestMethod]
        public void PasswordWithSmallLetters()
        {
            string password = GenerateRandomLetters(6, 'a', 'z');
            Assert.AreEqual(6, VerifySmallLetters(password, 'a', 'z'));
        }

        [TestMethod]
        public void PasswordWithSmallAndCapitalLetters()
        {
            string password = GenerateRandomLetters(3, 'a', 'z') + GenerateRandomLetters(3, 'A', 'Z');
            Assert.AreEqual(3, VerifySmallLetters(password, 'a', 'z'));
            Assert.AreEqual(3, VerifySmallLetters(password, 'A', 'Z'));
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

        string GenerateRandomLetters(int nrOfLetters, char lowerLimit, char upperLimit)
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

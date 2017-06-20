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
            string password = AddRandomCharacter(6, 'a', 'z');
            Assert.AreEqual(6, VerifyCharacter(password, 'a', 'z'));
        }

        [TestMethod]
        public void PasswordWithSmallAndCapitalLetters()
        {
            string password = AddRandomCharacter(3, 'a', 'z') + AddRandomCharacter(3, 'A', 'Z');
            Assert.AreEqual(3, VerifyCharacter(password, 'a', 'z'));
            Assert.AreEqual(3, VerifyCharacter(password, 'A', 'Z'));
        }

        [TestMethod]
        public void PasswordWithSmallCapitalLettersAndDigits()
        {
            string password = AddRandomCharacter(2, 'a', 'z') + AddRandomCharacter(1, 'A', 'Z') + AddRandomCharacter(1,'0', '9');
            Assert.AreEqual(1, VerifyCharacter(password, 'A', 'Z'));
            Assert.AreEqual(2, VerifyCharacter(password, 'a', 'z'));
            Assert.AreEqual(1, VerifyCharacter(password, '0', '9'));
        }

        [TestMethod]
        public void PasswordWithSmallCapitalLettersAndDigits2()
        {
            Password passwordOptions = new Password(4, 2, 1, 1, 0, false, false);
            string password = GeneratePassword(passwordOptions);
            Assert.AreEqual(1, VerifyCharacter(password, 'A', 'Z'));
            Assert.AreEqual(2, VerifyCharacter(password, 'a', 'z'));
            Assert.AreEqual(1, VerifyCharacter(password, '0', '9'));
        }

        [TestMethod]
        public void PasswordWithSmallCapitalLettersDigitsAndSymbols()
        {
            Password passwordOptions = new Password(8, 5, 1, 2, 1, false, false);
            string password = GeneratePassword(passwordOptions);
            Assert.AreEqual(1, VerifyCharacter(password, 'A', 'Z'));
            Assert.AreEqual(5, VerifyCharacter(password, 'a', 'z'));
            Assert.AreEqual(2, VerifyCharacter(password, '0', '9'));
            Assert.AreEqual(1, VerifySymbol(password));
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

        string GeneratePassword (Password password)
        {
            return AddRandomCharacter(password.capitalLetters, 'A', 'Z') +
                AddRandomCharacter(password.smallLetters, 'a', 'z') +
                AddRandomSymbols(password.symbols) +
                AddRandomCharacter(password.digits, '0', '9');
        }

        char GenerateRandomCharacter(char lowerLimit, char upperLimit)
        {
            return (char)(random.Next(lowerLimit, upperLimit + 1));
        }

        string AddRandomCharacter(int nrOfLetters, char lowerLimit, char upperLimit)
        {
            string password = "";
            for (int i = 0; i < nrOfLetters; i++)
            {
                password += GenerateRandomCharacter(lowerLimit, upperLimit);
            }
            return password;
        }

        string AddRandomSymbols(int nrOfSymbols)
        {
            string symbols = "!#$%&'()*+,-./:;<=>?@[]^_`{|}~" + '"';
            string password = "";
            for (int i = 0; i < nrOfSymbols; i++)
            {
                password += symbols[random.Next(0, 31)];
            }
            return password;
        }

        int VerifyCharacter(string password, char lowerLimit, char upperLimit)
        {
            int counter = 0;
            foreach (char c in password)
                if (lowerLimit <= c && c <= upperLimit)
                    counter++;
            return counter;
        }

        int VerifySymbol(string password)
        {
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (!Char.IsLetterOrDigit(password[i]))
                    counter++;
            }
            return counter;
        }
    }
}

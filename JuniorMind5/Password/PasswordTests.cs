using System;
using Xunit;

namespace Password
{
    
    public class PasswordTests
    {
        [Fact]
        public void PasswordWithSmallLetters()
        {
            string password = AddRandomCharacter(6, 'a', 'z', false);
            Assert.Equal(6, VerifyCharacter(password, 'a', 'z'));
        }

        [Fact]
        public void PasswordWithSmallAndCapitalLetters()
        {
            string password = AddRandomCharacter(3, 'a', 'z', false) + AddRandomCharacter(3, 'A', 'Z', false);
            Assert.Equal(3, VerifyCharacter(password, 'a', 'z'));
            Assert.Equal(3, VerifyCharacter(password, 'A', 'Z'));
        }

        [Fact]
        public void PasswordWithSmallCapitalLettersAndDigits()
        {
            string password = AddRandomCharacter(2, 'a', 'z', false) + AddRandomCharacter(1, 'A', 'Z', false) + AddRandomCharacter(1,'0', '9', false);
            Assert.Equal(1, VerifyCharacter(password, 'A', 'Z'));
            Assert.Equal(2, VerifyCharacter(password, 'a', 'z'));
            Assert.Equal(1, VerifyCharacter(password, '0', '9'));
        }

        [Fact]
        public void PasswordWithSmallCapitalLettersAndDigits2()
        {
            Password passwordOptions = new Password(4, 2, 1, 1, 0, false, false);
            string password = GeneratePassword(passwordOptions);
            Assert.Equal(1, VerifyCharacter(password, 'A', 'Z'));
            Assert.Equal(2, VerifyCharacter(password, 'a', 'z'));
            Assert.Equal(1, VerifyCharacter(password, '0', '9'));
        }

        [Fact]
        public void PasswordWithSmallCapitalLettersDigitsAndSymbols()
        {
            Password passwordOptions = new Password(8, 5, 1, 2, 1, false, false);
            string password = GeneratePassword(passwordOptions);
            Assert.Equal(1, VerifyCharacter(password, 'A', 'Z'));
            Assert.Equal(5, VerifyCharacter(password, 'a', 'z'));
            Assert.Equal(2, VerifyCharacter(password, '0', '9'));
            Assert.Equal(1, VerifySymbol(password));
        }

        [Fact]
        public void PasswordWithouthSimilarCharacters()
        {
            Password passwordOptions = new Password(8, 5, 1, 2, 1, true, false);
            string password = GeneratePassword(passwordOptions);
            Assert.Equal(1, VerifyCharacter(password, 'A', 'Z'));
            Assert.Equal(5, VerifyCharacter(password, 'a', 'z'));
            Assert.Equal(2, VerifyCharacter(password, '0', '9'));
            Assert.Equal(1, VerifySymbol(password));
            Assert.Equal(passwordOptions.exludeSimilarCharacters, VerifySimilarAndAmbiguous(password));
        }

        [Fact]
        public void PasswordWithouthSimilarAndAmbiguousCharacters()
        {
            Password passwordOptions = new Password(8, 5, 1, 2, 1, true, true);
            string password = GeneratePassword(passwordOptions);
            Assert.Equal(1, VerifyCharacter(password, 'A', 'Z'));
            Assert.Equal(5, VerifyCharacter(password, 'a', 'z'));
            Assert.Equal(2, VerifyCharacter(password, '0', '9'));
            Assert.Equal(1, VerifySymbol(password));
            Assert.Equal(passwordOptions.exludeSimilarCharacters, VerifySimilarAndAmbiguous(password));
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
            return AddRandomCharacter(password.capitalLetters, 'A', 'Z', password.exludeSimilarCharacters) +
                AddRandomCharacter(password.smallLetters, 'a', 'z', password.exludeSimilarCharacters) +
                AddRandomSymbols(password.symbols, password.excludeAmbiguousCharacters) +
                AddRandomCharacter(password.digits, '0', '9', password.exludeSimilarCharacters);
        }

        char GenerateRandomCharacter(char lowerLimit, char upperLimit)
        {
            return (char)(random.Next(lowerLimit, upperLimit + 1));
        }

        string AddRandomCharacter(int nrOfCharacters, char lowerLimit, char upperLimit, bool similar)
        {
            string password = "";
            string similarCharacters = "l1Io0O";
            for (int i = 0; i < nrOfCharacters; i++)
            {
                char character = (char) GenerateRandomCharacter(lowerLimit, upperLimit);
                if (similar && similarCharacters.Contains(character.ToString()))
                {
                    i--;
                    continue;
                }
                password += character;
            }
            return password;
        }

        string AddRandomSymbols(int nrOfSymbols, bool ambiguous)
        {
            string symbols = "!#$%&'()*+,-./:;<=>?@[]^_`{|}~" + '"';
            string ambiguousCharacters = "{}[]()/\'~,;.<>" + '"';
            string password = "";
            for (int i = 0; i < nrOfSymbols; i++)
            {
                char symbol = symbols[random.Next(0, 31)];
                if (ambiguous && ambiguousCharacters.Contains(symbol.ToString()))
                {
                    i--;
                    continue;
                }
                password += symbol;
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

        bool VerifySimilarAndAmbiguous(string password)
        {
            string similarCharacters = "l1Io0O{}[]()/\'~,;.<>" + '"';
            for (int i = 0; i < password.Length; i++)
            {
                if (password.IndexOf(similarCharacters) != -1)
                    return false;
            }
            return true;
            
        }
    }
}

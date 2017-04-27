using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumbers
{
    [TestClass]
    public class RomanNumbersTests
    {
        [TestMethod]
        public void ConvertNumberSmallerThanTen()
        {
            string romanNumber = ConvertNumberInRomanNumber(5);
            Assert.AreEqual("V", romanNumber);
        }

        [TestMethod]
        public void ConvertNumberSmallerThanFifty()
        {
            string romanNumber = ConvertNumberInRomanNumber(26);
            Assert.AreEqual("XXVI", romanNumber);
        }

        string ConvertNumberInRomanNumber(int number)
        {
            string[] romanNumbersSmallerThanTen = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] romanNumbersUpToOneHundred = { "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC", "C" };
            if (number < 10)
                return romanNumbersSmallerThanTen[number - 1];
            if (number >= 10)
                return romanNumbersUpToOneHundred[(number / 10) - 1] + romanNumbersSmallerThanTen[(number % 10) - 1];
            else
                return "Numarul este mai mare decat 100!";
        }

    }
}

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

        string ConvertNumberInRomanNumber(int number)
        {
            string[] romanNumbersSmallerThanTen = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            return romanNumbersSmallerThanTen[number-1];
        }

    }
}

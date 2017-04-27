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
            return "";
        }

    }
}

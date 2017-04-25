using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void TextIfIsMultipleOfThree()
        {
            string textForMultipleOfThree = DisplayTextIfIsMultiple(6);
            Assert.AreEqual("Fizz" , textForMultipleOfThree);
        }

        string DisplayTextIfIsMultiple (int number)
        {
            return "0";
        }
    }
}

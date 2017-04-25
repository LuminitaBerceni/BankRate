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
            if (number % 3 == 0)
                return "Fizz";
            else
                return "It's not a multiple of 3 !";
            
        }
    }
}

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

        [TestMethod]
        public void TextIfIsMultipleOfFive()
        {
            string textForMultipleOfFive = DisplayTextIfIsMultiple(10);
            Assert.AreEqual("Buzz", textForMultipleOfFive);
        }

        [TestMethod]
        public void TextIfIsMultipleOfThreeAndFive()
        {
            string textForMultipleOfThreeAndFive = DisplayTextIfIsMultiple(15);
            Assert.AreEqual("FizzBuzz", textForMultipleOfThreeAndFive);
        }

        [TestMethod]
        public void TextIfIsNotMultipleOfThreeOrFive()
        {
            string textForNotMultipleOfThreeOrFive = DisplayTextIfIsMultiple(14);
            Assert.AreEqual("It's not a multiple of 3 or 5 !", textForNotMultipleOfThreeOrFive);
        }

        string DisplayTextIfIsMultiple (int number)
        {
            String[] text = { "Fizz" , "Buzz" , "FizzBuzz"};
            if ((number % 3 == 0) && (number % 5 == 0))
                return text[2];
            if (number % 5 == 0)
                return text[1];
            if (number % 3 == 0)
                return text[0];  
            return "It's not a multiple of 3 or 5 !";
            
        }
    }
}

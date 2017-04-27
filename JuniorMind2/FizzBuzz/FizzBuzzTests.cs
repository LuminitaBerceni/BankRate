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
            string text = "";
            if (IsDivisible(number, 15))
                text = "FizzBuzz";
            else if (IsDivisible(number, 3))
                text = "Fizz";
            else if (IsDivisible(number, 5))
                text = "Buzz";
            else
                text = "It's not a multiple of 3 or 5 !";
            return text;
        }

        private static bool IsDivisible(int multiple,int divisor)
        {
            return multiple % divisor == 0;
        }
    }
}

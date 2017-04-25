﻿using System;
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

        string DisplayTextIfIsMultiple (int number)
        {
            if (number % 3 == 0)
                return "Fizz";
            if (number % 5 == 0)
                return "Buzz";
            return "It's not a multiple of 3 !";
            
        }
    }
}

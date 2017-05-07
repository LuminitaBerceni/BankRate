using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DaysUntilFutureLunch
{
    [TestClass]
    public class DaysUntilFutureLunchTests
    {
        [TestMethod]
        public void CalculateDaysUntilFutureLunch()
        {
            Assert.AreEqual(12, CalculateLeastCommonMultiple(4,6));
        }

        int CalculateLeastCommonMultiple(int firstNumber, int secondNumber )
        {
            int max = (firstNumber > secondNumber) ? firstNumber : secondNumber;
            do
            {
                if (max % firstNumber == 0 && max % secondNumber == 0)
                    return max;
                else
                    max++;
            } while (true);
        }
    }
}

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
            return 0;
        }
    }
}

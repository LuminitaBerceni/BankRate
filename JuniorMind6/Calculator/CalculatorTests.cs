using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CalculateExpressionWithOneOperator()
        {
            Assert.AreEqual(12 , CalculateExpression("* 3 4"));
        }

        double CalculateExpression(string expression)
        {
            return 0;
        }
    }
}

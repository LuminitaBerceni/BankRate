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
            int index = 0;
            Assert.AreEqual(12 , CalculateExpression("* 3 4", ref index));
        }

        [TestMethod]
        public void CalculateExpressionWithTwoOperators()
        {
            int index = 0;
            Assert.AreEqual(4, CalculateExpression("* + 1 1 2", ref index));
        }

        public double CalculateExpression(string expression, ref int index)
        {
            string[] elements = expression.Split(' ');
            string currentElement = elements[index++];
            double number;
            if (Double.TryParse(currentElement, out number))
            {
                return number;
            }
            switch (currentElement)
            {
                case "+": return CalculateExpression(expression, ref index) + CalculateExpression(expression, ref index);
                case "-": return CalculateExpression(expression, ref index) - CalculateExpression(expression, ref index);
                case "*": return CalculateExpression(expression, ref index) * CalculateExpression(expression, ref index);
                default: return CalculateExpression(expression, ref index) / CalculateExpression(expression, ref index);
            }
        }
    }
}

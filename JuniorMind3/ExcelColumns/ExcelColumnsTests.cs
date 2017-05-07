using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExcelColumns
{
    [TestClass]
    public class ExcelColumnsTests
    {
        [TestMethod]
        public void FindExcelColumnWithOneLetter()
        {
            Assert.AreEqual("A", FindLettersForExcelColumns(1));
        }

        [TestMethod]
        public void FindExcelColumnWithOneLetter2()
        {
            Assert.AreEqual("Z", FindLettersForExcelColumns(26));
        }

        [TestMethod]
        public void FindExcelColumnWithTwoLetters()
        {
            Assert.AreEqual("AA", FindLettersForExcelColumns(27));
        }

        [TestMethod]
        public void FindExcelColumnWithTwoLetters2()
        {
            Assert.AreEqual("AZ", FindLettersForExcelColumns(52));
        }

        string FindLettersForExcelColumns(int columnNumber)
        {
            string result = "";
            while (columnNumber > 0)
            {
                columnNumber -= 1;
                result = (char)('A' + columnNumber % 26) + result;
                columnNumber = columnNumber / 26;
            }
            return result;
        }
    }
}

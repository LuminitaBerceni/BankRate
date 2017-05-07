﻿using System;
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
        public void FindExcelColumnWithTwoLetters()
        {
            Assert.AreEqual("AA", FindLettersForExcelColumns(27));
        }

        string FindLettersForExcelColumns(int columnNumber)
        {
            string result = "";
            while (columnNumber > 0)
            {
                result = (char)('@' + columnNumber % 26) + result;
                columnNumber = columnNumber / 26;
            }
            return result;
        }
    }
}

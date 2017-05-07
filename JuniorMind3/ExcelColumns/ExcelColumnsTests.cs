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
            Assert.AreEqual('A', FindLettersForExcelColumns(1));
        }

        char FindLettersForExcelColumns(int columnNumber)
        {
            return (char)('@' + columnNumber);
        }
    }
}

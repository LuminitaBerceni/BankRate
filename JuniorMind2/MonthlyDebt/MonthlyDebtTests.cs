using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MonthlyDebt
{
    [TestClass]
    public class MonthlyDebtTests
    {
        [TestMethod]
        public void TotalDebtForUnderTenDelayDays()
        {
            Assert.AreEqual(108,CalculateTotalDebt(100,4));
        }

        [TestMethod]
        public void TotalDebtForOverTenAndUnderThirtyDelayDays()
        {
            Assert.AreEqual(155, CalculateTotalDebt(100, 11));
        }

        decimal CalculateTotalDebt (decimal monthRent, int delayDays)
        {
            decimal penaltiPerDay = delayDays > 10 ? (decimal) 5/100 : (decimal) 2 / 100;
            decimal penalties = delayDays * monthRent * penaltiPerDay;
            return monthRent + penalties;
        }
    }
}

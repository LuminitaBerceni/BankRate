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

        [TestMethod]
        public void TotalDebtForOverThirtyDelayDays()
        {
            Assert.AreEqual(410, CalculateTotalDebt(100, 31));
        }

        decimal CalculateTotalDebt (decimal monthRent, int delayDays)
        {
            decimal penaltiPerDay = GetPenaltiPerDay(delayDays);
            decimal penalties = delayDays * monthRent * penaltiPerDay;
            return monthRent + penalties;
        }

        private static decimal GetPenaltiPerDay(int delayDays)
        {
            if (delayDays < 10)
                return (decimal) 2 / 100;
            if (delayDays > 10 && delayDays < 30)
                return (decimal) 5 / 100;
            return (decimal) 10 / 100;
        }
    }
}

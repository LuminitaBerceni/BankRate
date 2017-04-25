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
            decimal penalties = delayDays * monthRent * GetPenaltyPerDay(delayDays);
            return monthRent + penalties;
        }

        private static decimal GetPenaltyPerDay(int delayDays)
        {
            int [] penaltyRate = { 2, 5, 10 };
            if (delayDays < 10)
                return GetPercent(penaltyRate[0]);
            if (delayDays > 10 && delayDays < 30)
                return GetPercent(penaltyRate[1]);
            return GetPercent(penaltyRate[2]);
        }

        private static decimal GetPercent(int rate)
        {
            return (decimal) rate / 100;
        }
    }
}

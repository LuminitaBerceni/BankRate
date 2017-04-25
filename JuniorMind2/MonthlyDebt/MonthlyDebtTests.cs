﻿using System;
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

        decimal CalculateTotalDebt (decimal monthRent, int delayDays)
        {
            decimal penalties = delayDays * monthRent * (decimal) 2 / 100;
            return monthRent + penalties;
        }
    }
}

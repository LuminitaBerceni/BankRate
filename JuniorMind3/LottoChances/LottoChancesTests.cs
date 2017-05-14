using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LottoChances
{
    [TestClass]
    public class LottoChancesTests
    {
        [TestMethod]
        public void LottoChance1Of2()
        {
            Assert.AreEqual(0.5 , CalculateLottoChances(1, 2));
        }

        [TestMethod]
        public void LottoChance1Of4()
        {
            Assert.AreEqual(0.25, CalculateLottoChances(1, 4));
        }

        double CalculateLottoChances (double NrOfExtractions, double RangeOfExtractions)
        {
            return NrOfExtractions / RangeOfExtractions;
        }
    }
}

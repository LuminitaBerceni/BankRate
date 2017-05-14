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

        [TestMethod]
        public void LottoChance6Of49()
        {
            Assert.AreEqual(0.00000007151123842018516d, CalculateLottoChances(6, 49));
        }

        double CalculateLottoChances (double NrOfExtractions, double RangeOfExtractions)
        {
            double chances = 1;
            for (int i = 0; i < NrOfExtractions; i++)
            {
                chances *= (NrOfExtractions - i) / (RangeOfExtractions - i);
            }
            return chances;
        }
    }
}

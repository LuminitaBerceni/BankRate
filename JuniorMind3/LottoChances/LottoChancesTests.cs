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

        double CalculateLottoChances (double NrOfExtractions, double RangeOfExtractions)
        {
            return 0;
        }
    }
}

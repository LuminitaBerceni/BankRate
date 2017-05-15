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
            Assert.AreEqual(0.00000007151123842018516, CalculateLottoChances(6, 49));
        }

        [TestMethod]
        public void LottoChance5Of49()
        {
            Assert.AreEqual(0.0000005244157484146906, CalculateLottoChances(5, 49), 0.00000000001);
        }

        [TestMethod]
        public void LottoChance4Of49()
        {
            Assert.AreEqual(0.00000471974173573222, CalculateLottoChances(4, 49));
        }


        double CalculateLottoChances (double NrOfExtractions, double RangeOfExtractions)
        {
            double chances = 1 / CalculateCombination(RangeOfExtractions,NrOfExtractions);
            return chances;
        }

        double CalculateCombination (double n, double k)
        {
            double numberOfCombinations = CalculateFactorial(n) / (CalculateFactorial(k) * CalculateFactorial(n - k));
            return numberOfCombinations;
        }

        double CalculateFactorial(double number)
        {
            double factorial = 1;
            for (int i = 2; i <= number; i++)
                factorial *= i;
            return factorial;
        }
    }
}

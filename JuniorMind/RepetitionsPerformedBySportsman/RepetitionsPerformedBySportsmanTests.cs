using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepetitionsPerformedBySportsman
{
    [TestClass]
    public class RepetitionsPerformedBySportsmanTests
    {
        [TestMethod]
        public void RepetitionsForTwoRounds()
        {
            int repetitions = CalculateRepetitionsPerformedBySportsman(2);
            Assert.AreEqual(4, repetitions);
        }

        int CalculateRepetitionsPerformedBySportsman(int numberOfRoundAndRepetitions)
        {
            return numberOfRoundAndRepetitions * numberOfRoundAndRepetitions;
        }
    }
}

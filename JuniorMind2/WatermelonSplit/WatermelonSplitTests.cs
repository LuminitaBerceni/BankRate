using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WatermelonSplit
{
    [TestClass]
    public class WatermelonSplitTests
    {
        [TestMethod]
        public void CanSplitWatermelon()
        {
            Assert.AreEqual("DA",CanSplitWatermelonInTwoEvenParts(10));
        }

        [TestMethod]
        public void CantSplitWatermelon()
        {
            Assert.AreEqual("NU", CanSplitWatermelonInTwoEvenParts(5));
        }

        string CanSplitWatermelonInTwoEvenParts(int watermelonWeight)
        {
            return (watermelonWeight % 2 == 0 && watermelonWeight >= 4) ? "DA" : "NU";
        }
    }
}

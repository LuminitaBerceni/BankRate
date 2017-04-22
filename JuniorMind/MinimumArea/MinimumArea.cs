using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MinimumArea
{
    [TestClass]
    public class MinimumArea
    {
        [TestMethod]
        public void CalculateMinimumArea1()
        {
            float area = CalculateMinimumArea(1,2,3,3,1,5);
            Assert.AreEqual(3,area);
        }

        float CalculateMinimumArea(float columnOneX, float columnOneY, float columnTwoX, float columnTwoY, float columnThreeX, float columnThreeY )
        {
            return 0;
        }
    }
}

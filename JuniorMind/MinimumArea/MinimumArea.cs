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

        [TestMethod]
        public void CalculateMinimumArea2()
        {
            float area = CalculateMinimumArea(1, 2, -1, -1, 3, 1);
            Assert.AreEqual(4, area);
        }

        float CalculateMinimumArea(float columnOneX, float columnOneY, float columnTwoX, float columnTwoY, float columnThreeX, float columnThreeY)
        {

            float determinant = columnOneX * columnTwoY + columnTwoX * columnThreeY + columnOneY * columnThreeX - columnTwoY * columnThreeX - columnOneY * columnTwoX - columnOneX * columnThreeY;
            return Math.Abs(determinant) / 2;
        }

    }
}

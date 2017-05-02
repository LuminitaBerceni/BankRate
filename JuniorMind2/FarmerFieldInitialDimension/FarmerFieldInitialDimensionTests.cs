using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarmerFieldInitialDimension
{
    [TestClass]
    public class FarmerFieldInitialDimensionTests
    {
        [TestMethod]
        public void CalculateFieldForSmallDimensions()
        {
            double initialField = CalculateFieldInitialDimension(1, 2);
            Assert.AreEqual(1, initialField);
        }

        double CalculateFieldInitialDimension(int finalWidth, int finalArea)
        {
            double delta = finalWidth * finalWidth + 4 * finalArea;
            if (delta > 0)
            {
                double x1 = (-finalWidth + Math.Sqrt(delta)) / 2;
                return x1 * x1;
            }
            else
                return 0;
        }
    }
}

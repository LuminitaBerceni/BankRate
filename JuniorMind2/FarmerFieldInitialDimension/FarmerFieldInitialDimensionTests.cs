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
            return 0;
        }
    }
}

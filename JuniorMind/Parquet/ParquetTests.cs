using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Parquet
{
    [TestClass]
    public class ParquetTests
    {
        [TestMethod]
        public void ParquetFor2X3Room()
        {
            double parquet = CalculateNrParquet(2, 3, 1, 2);
            Assert.AreEqual(4, parquet);
        }

        double CalculateNrParquet(double roomWidth, double roomLenght, double parquetWidth, double parquetLenght)
        {
            double parquetPieces = (roomWidth * roomLenght)/(parquetWidth*parquetLenght);
            double parquetLoss = 0.15 * Math.Ceiling(parquetPieces);
            return Math.Ceiling(parquetPieces + parquetLoss);
        }
    }
}

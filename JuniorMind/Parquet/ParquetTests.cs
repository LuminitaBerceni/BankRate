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

        [TestMethod]
        public void ParquetFor5X5Room()
        {
            double parquet = CalculateNrParquet(5, 5, 2, 3);
            Assert.AreEqual(5, parquet);
        }

        double CalculateNrParquet(double roomWidth, double roomLenght, double parquetWidth, double parquetLenght)
        {
            double roomDimension = roomWidth * roomLenght;
            double parquetDimension = parquetWidth * parquetLenght;
            double parquetPieces = roomDimension/parquetDimension;
            double parquetLoss = 0.15 * Math.Ceiling(parquetPieces);
            return Math.Ceiling(parquetPieces + parquetLoss);
        }
    }
}

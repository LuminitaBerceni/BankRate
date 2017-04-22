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
            return 0;
        }
    }
}

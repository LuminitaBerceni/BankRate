using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LottoExtraction
{
    [TestClass]
    public class LottoExtractionTests
    {
        [TestMethod]
        public void SortNumbers()
        {
            int[] lottoNumbers = new int[] {10, 4, 28, 31, 49, 3};
            CollectionAssert.AreEqual(new int[] { 3, 4, 10, 28, 31, 49 }, SortLottoNumbers(lottoNumbers));
        }

        int[] SortLottoNumbers(int[] numbers)
        {
            return new int[6];
        }
    }
}

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
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int minim = numbers[i];
                int position = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < minim)
                    {
                        position = j;
                        minim = numbers[j];
                    }
                }
                numbers[position] = numbers[i];
                numbers[i] = minim;
            }
            return numbers;
        }
        
    }
}

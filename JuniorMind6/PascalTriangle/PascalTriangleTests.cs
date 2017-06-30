using System;
using Xunit;

namespace PascalTriangle
{
    
    public class PascalTriangleTests
    {
        [Fact]
        public void PascalTriangleLine3()
        {
            Assert.Equal(new int[] { 1, 2, 1 } , GeneratePascalTriangle(3));
        }

        int [] GeneratePascalTriangle (int line)
        {
            int[] result = new int[line];
            result[0] = 1;
            result[result.Length - 1] = 1;
            if (line < 3) return result;
            int[] previousLine = GeneratePascalTriangle(line - 1);
            for (int i = 1; i < line - 1; i++)
            {
                result[i] = previousLine[i] + previousLine[i - 1];
            }
            return result;
        }
    }
}

using System;
using Xunit;

namespace PascalTriangle
{
    
    public class PascalTriangleTests
    {
        [Fact]
        public void PascalTriangleLine1()
        {
            Assert.Equal(new int[] { 1 }, GeneratePascalTriangle(1));
        }

        [Fact]
        public void PascalTriangleLine2()
        {
            Assert.Equal(new int[] { 1, 1 }, GeneratePascalTriangle(2));
        }

        [Fact]
        public void PascalTriangleLine3()
        {
            Assert.Equal(new int[] { 1, 2, 1 } , GeneratePascalTriangle(3));
        }

        [Fact]
        public void PascalTriangleLine4()
        {
            Assert.Equal(new int[] { 1, 3, 3, 1 }, GeneratePascalTriangle(4));
        }

        [Fact]
        public void PascalTriangleLine5()
        {
            Assert.Equal(new int[] { 1, 4, 6, 4, 1 }, GeneratePascalTriangle(5));
        }

        [Fact]
        public void PascalTriangleLine6()
        {
            Assert.Equal(new int[] { 1, 5, 10, 10, 5, 1 }, GeneratePascalTriangle(6));
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

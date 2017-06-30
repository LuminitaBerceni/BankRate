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
            return new int[] {0};
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Intersection
{
    [TestClass]
    public class IntersectionTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        struct Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public void GetDirections(Directions direction)
            {
                if (direction == Directions.up) y++;
                if (direction == Directions.down) y--;
                if (direction == Directions.right) x++;
                if (direction == Directions.left) x--;
            }

        }

        enum Directions
        {
            up,
            down,
            right,
            left
        }

        
    }
}

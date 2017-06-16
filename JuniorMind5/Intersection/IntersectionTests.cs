using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Intersection
{
    [TestClass]
    public class IntersectionTests
    {
        [TestMethod]
        public void Intersection1Test()
        {
            Assert.AreEqual(new Point(2, 1), GetFirstIntersection(new Point(2, 1), new Directions[] { Directions.up, Directions.right, Directions.down, Directions.left }));
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

        Point GetFirstIntersection(Point point, Directions[] directions)
        {
            return new Point(0, 0);
        }
    }
}

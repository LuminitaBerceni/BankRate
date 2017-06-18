using System;
using Xunit;

namespace Intersection
{

    public class IntersectionTests
    {
        [Fact]
        public void Intersection1Test()
        {
            Assert.Equal(new Point(1, 2),
                GetFirstIntersection(new Point(1, 2),
                new Directions[] { Directions.up, Directions.right, Directions.down, Directions.left, Directions.up }));
        }

        [Fact]
        public void Intersection2Test()
        {
            Assert.Equal(new Point(2, 3),
                GetFirstIntersection(new Point(1, 1),
                new Directions[] { Directions.up, Directions.up, Directions.right, Directions.right, Directions.down, Directions.left, Directions.up, Directions.up }));
        }

        [Fact]
        public void NoIntersectionTest()
        {
            Assert.Equal(new Point(0,0),
                GetFirstIntersection(new Point(1, 2),
                new Directions[] { Directions.right, Directions.down, Directions.right, Directions.up, Directions.right}));
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
            Point[] checkPoints = new Point[directions.Length + 1];
            checkPoints[0] = point;

            for (int i = 0; i < directions.Length; i++)
            {
                point.GetDirections(directions[i]);
                checkPoints[i+1] = point;

                if(CheckIntersection(point, checkPoints))
                    return point;
            }

            return new Point(0,0);
        }
        
        bool CheckIntersection(Point point, Point[] checkPoints)
        {
            int counter = 0;
            foreach (var savedPoint in checkPoints)
            {
                if (savedPoint.x == point.x && savedPoint.y == point.y)
                    counter++;
            }
            return (counter > 1);
        }

    }

}
    


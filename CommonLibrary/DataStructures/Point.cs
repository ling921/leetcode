using System;

namespace CommonLibrary.DataStructures
{
    public struct Point : IEquatable<Point>
    {
        public int x;
        public int y;

        public Point(int a, int b)
        {
            x = a;
            y = b;
        }

        public bool Equals(Point other) => other.x == x && other.y == y;

        public override string ToString()
        {
            return $"({x},{y})";
        }

        public override bool Equals(object obj) => obj is Point point && Equals(point);

        public override int GetHashCode() => x.GetHashCode() & y.GetHashCode();
    }
}

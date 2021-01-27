namespace CommonLibrary
{
    public struct Point
    {
        public int x;
        public int y;

        public Point(int a, int b)
        {
            x = a;
            y = b;
        }

        public override string ToString()
        {
            return $"({this.x}, {this.y})";
        }

        public override bool Equals(object obj)
        {
            if (obj is Point point)
                return this.x == point.x && this.y == point.y;
            return false;
        }

        public override int GetHashCode() => base.GetHashCode();
    }
}

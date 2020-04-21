using System.Collections.Generic;
using System.Linq;

namespace _87._Erect_the_Fence
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public IList<Point> OuterTrees(Point[] points)
        {
            int len = points.Length;
            if (len < 4)
                return points.ToList();
            Point xNegative = points[0];
            Point xPositive = points[0];
            Point yNegative = points[0];
            Point yPositive = points[0];
            for (int i = 1; i < len; i++)
            {
                if (xNegative.x > points[i].x)
                    xNegative = points[i];
                if (xPositive.x < points[i].x)
                    xPositive = points[i];
                if (yNegative.y > points[i].y)
                    yNegative = points[i];
                if (yPositive.y < points[i].y)
                    yPositive = points[i];
                xNegative.Equal(xPositive)
            }
        }
    }

    public static class ExtensionMethod
    {
        public static bool Equal(this Point a, Point b)
        {
            if (a.x == b.x && a.y == b.y)
                return true;
            return false;
        }
    }

    public class Point
    {
        public int x;
        public int y;
        public Point() { x = 0; y = 0; }
        public Point(int a, int b) { x = a; y = b; }
    }
}

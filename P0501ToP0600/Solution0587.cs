using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P0501ToP0600
{
    /// <summary>
    /// 587. Erect the Fence
    /// </summary>
    public class Solution0587
    {
        public Solution0587()
        {
            Console.WriteLine();
        }

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
                xNegative.Equals(xPositive);
            }
            return null;
        }
    }
}

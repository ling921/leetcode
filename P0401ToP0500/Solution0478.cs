using System;
using System.Threading;

namespace P0401ToP0500
{
    /// <summary>
    /// 478. Generate Random Point in a Circle
    /// </summary>
    public class Solution0478
    {
        public Solution0478()
        {
            Solution solution = new Solution(1, 0, 0);

            for (int i = 0; i < 100; i++)
            {
                double[] point = solution.RandPoint();
                Console.WriteLine(Math.Sqrt(point[0] * point[0] + point[1] * point[1]));
                Thread.Sleep(new Random().Next(200));
            }

        }

        private class Solution
        {
            public Solution(double radius, double x_center, double y_center)
            {
                this.radius = radius;
                this.x_center = x_center;
                this.y_center = y_center;
            }

            private double radius;
            private double x_center;
            private double y_center;

            public double[] RandPoint()
            {
                double x, y;
                Random rnd = new Random();
                while (true)
                {
                    x = rnd.NextDouble() * 2 - 1;
                    y = rnd.NextDouble() * 2 - 1;
                    if (x * x + y * y <= 1)
                        return new double[] { x_center + radius * x, y_center + radius * y };
                }
            }
        }
    }
}

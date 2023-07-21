namespace P1001ToP1100
{
    /// <summary>
    /// 1052. 爱生气的书店老板
    /// </summary>
    public class Solution1052
    {
        public Solution1052()
        {
            var customers = "[1,0,1,2,1,1,7,5]".ToArray<int>();
            var grumpy = "[0,1,0,1,0,1,0,1]".ToArray<int>();
            var X = 3;
            WriteLine(MaxSatisfied(customers, grumpy, X));
        }

        public int MaxSatisfied(int[] customers, int[] grumpy, int X)
        {
            int sum = 0, count = 0, max = 0;
            for (int i = 0; i < customers.Length; i++)
            {
                sum += customers[i] * (1 - grumpy[i]);
                count += customers[i] * grumpy[i];
                if (i >= X)
                {
                    count -= customers[i - X] * grumpy[i - X];
                }
                max = Math.Max(count, max);
            }
            return sum + max;
        }
    }
}

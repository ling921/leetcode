namespace P0301ToP0400
{
    /// <summary>
    /// 375. Guess Number Higher or Lower II
    /// </summary>
    public class Solution0375
    {
        public Solution0375()
        {
            int n = 100;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"n = {i} ；Min Money = {GetMoneyAmount(i)}");
            }
            Console.ReadKey();
        }

        public int GetMoneyAmount(int n)
        {
            int[,] dp = new int[n + 1, n + 1];
            for (int len = 2; len <= n; len++)
            {
                for (int start = 1; start <= n - len + 1; start++)
                {
                    if (len == 2)
                        dp[start, len] = start;
                    else if (len == 3)
                        dp[start, len] = start + 1;
                    else
                    {
                        int value = int.MaxValue;
                        for (int i = 2; i < len; i++)
                            value = Math.Min(value, start + i - 1 + Math.Max(dp[start, i], dp[start + i, len - i + 1]));
                        dp[start, len] = value;
                    }
                }
            }
            return dp[1, n];
        }
    }
}

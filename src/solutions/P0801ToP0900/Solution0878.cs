namespace P0801ToP0900
{
    /// <summary>
    /// 878. Nth Magical Number
    /// </summary>
    public class Solution0878
    {
        public Solution0878()
        {
            Console.WriteLine(NthMagicalNumber(100000000, 39997, 38873));
        }

        public int NthMagicalNumber(int N, int A, int B)
        {
            if (A % B == 0 || B % A == 0)
                return (int)((Int64)Math.Min(A, B) * N % 1000000007);
            int lcm = LowestCommonMultiple(A, B);
            int d = lcm / A + lcm / B - 1;
            if (N % d == 0)
                return (int)((Int64)N / d * lcm % 1000000007);
            Int64 left = (Int64)N / d * lcm, right = (Int64)(N / d + 1) * lcm - 1, mid = (left + right) / 2;
            while (left < right)
            {
                Int64 i = mid / A + mid / B - mid / lcm;
                if (i > N)
                    right = mid;
                else if (i < N)
                    left = mid;
                else
                    break;
                mid = (left + right) / 2;
            }
            while (mid > 0)
            {
                if ((mid % A == 0 || mid % B == 0))
                    break;
                mid--;
            }
            return (int)(mid % 1000000007);
        }

        private int LowestCommonMultiple(int a, int b)
        {
            int i = 2, j = 1;
            while (i <= Math.Min(a, b))
            {
                if (a % i == 0 && b % i == 0)
                    j = i;
                i++;
            }
            return a * b / j;
        }
    }
}

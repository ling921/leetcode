namespace _96._Rotate_Function
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int MaxRotateFunction(int[] A)
        {
            int sum = 0, f0 = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
                f0 += i * A[i];
            }
            int max = f0;
            for (int i = 1; i < A.Length; i++)
            {
                f0 = f0 + sum - A.Length * A[A.Length - i];
                max = max > f0 ? max : f0;
            }
            return max;
        }
    }
}

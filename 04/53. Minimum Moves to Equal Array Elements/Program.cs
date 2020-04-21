namespace _53._Minimum_Moves_to_Equal_Array_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int MinMoves(int[] nums)
        {
            int min = int.MaxValue, sum = 0;
            foreach (var n in nums)
            {
                min = min > n ? n : min;
                sum += n;
            }
            return sum - min * nums.Length;
        }
    }
}

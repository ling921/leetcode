namespace _13._Arithmetic_Slices
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int NumberOfArithmeticSlices(int[] A)
        {
            Slices = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {

            }
        }

        private int[] Slices { get; set; }

        private int GetSlicesFromLength(int len)
        {
            if (len < 3)
                return 0;
            if (len == 3)
                return 1;
            if (Slices[len - 1] == 0)
                Slices[len - 1] = GetSlicesFromLength(len - 1) + len - 2;
            return Slices[len - 1];
        }
    }
}

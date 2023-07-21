namespace P0001ToP0100
{
    /// <summary>
    /// 77. Combinations
    /// </summary>
    public class Solution0077
    {
        public Solution0077()
        {
            int n = 4;
            int k = 2;
            IList<IList<int>> result = Combine(n, k);
            foreach (IList<int> list in result)
            {
                foreach (int item in list)
                    Console.Write($"{item}  ");
                Console.WriteLine();
            }
            Console.Read();
        }

        public IList<IList<int>> Combine(int n, int k)
        {
            if (n * k == 0)
                return null;
            int len = Factorial(n) / (Factorial(k) * Factorial(n - k));
            int[,] combineArr = new int[len, k];
            IList<IList<int>> result = new List<IList<int>>();

            return result;
        }

        private int Factorial(int num)
        {
            return num == 1 ? 1 : Factorial(num - 1) * num;
        }

        private void Combine(int n, int k, List<int> list, ref IList<IList<int>> combineList)
        {
        }
    }
}

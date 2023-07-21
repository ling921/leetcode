namespace P0001ToP0100
{
    /// <summary>
    /// 89. Gray Code
    /// </summary>
    public class Solution0089
    {
        public Solution0089()
        {
            foreach (int v in GrayCode(11))
            {
                Console.WriteLine(v);
            }

            Console.Read();
        }

        public IList<int> GrayCode(int n)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < 1 << n; i++)
                result.Add(i ^ i >> 1);
            return result;
        }
    }
}

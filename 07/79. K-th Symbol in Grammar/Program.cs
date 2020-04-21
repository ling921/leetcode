using System;

namespace _79._K_th_Symbol_in_Grammar
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int N = 30, K = 434991989;
            Console.WriteLine(solution.KthGrammar(N, K));
            Console.Read();
        }
    }
    public class Solution
    {
        public int KthGrammar(int N, int K)
        {
            if (K == 1 && N == 1)
                return 0;
            else
                return K % 2 == 0 ? (KthGrammar(N - 1, K / 2) + 1) % 2 : KthGrammar(N - 1, (K + 1) / 2);
        }
    }
}

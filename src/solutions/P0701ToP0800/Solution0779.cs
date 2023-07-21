namespace P0701ToP0800
{
    /// <summary>
    /// 779. K-th Symbol in Grammar
    /// </summary>
    public class Solution0779
    {
        public Solution0779()
        {
            int N = 30, K = 434991989;
            Console.WriteLine(KthGrammar(N, K));
        }

        public int KthGrammar(int N, int K)
        {
            if (K == 1 && N == 1)
                return 0;
            else
                return K % 2 == 0 ? (KthGrammar(N - 1, K / 2) + 1) % 2 : KthGrammar(N - 1, (K + 1) / 2);
        }
    }
}

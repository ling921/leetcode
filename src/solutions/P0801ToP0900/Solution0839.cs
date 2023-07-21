namespace P0801ToP0900
{
    /// <summary>
    /// 839. Similar String Groups
    /// </summary>
    public class Solution0839
    {
        public Solution0839()
        {
            //string[] A = { "tars", "rats", "arts", "star" };
            string[] A = { "bpkvu", "bukvp", "vpkbu", "vpkub" };
            Console.WriteLine(NumSimilarGroups(A));
        }

        public int NumSimilarGroups(string[] A)
        {
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != null)
                {
                    SearchSimilarGroup(ref A, i);
                    count++;
                }
            }
            return count;
        }

        private void SearchSimilarGroup(ref string[] A, int index)
        {
            string str = A[index];
            A[index] = null;
            for (int i = 0; i < A.Length; i++)
                if (A[i] != null && i != index && IsSimilar(A[i], str))
                    SearchSimilarGroup(ref A, i);
        }

        private bool IsSimilar(string a, string b)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
                if (a[i] != b[i])
                    count++;
            return count == 2 || count == 0;
        }
    }
}

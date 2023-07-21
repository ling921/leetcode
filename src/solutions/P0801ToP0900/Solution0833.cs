namespace P0801ToP0900
{
    /// <summary>
    /// 833. Find And Replace in String
    /// </summary>
    public class Solution0833
    {
        public Solution0833()
        {
            string S = "vmokgggqzp";
            int[] indexes = new int[] { 3, 5, 1 };
            string[] sources = new string[] { "kg", "ggq", "mo" };
            string[] targets = new string[] { "s", "so", "bfr" };

            Console.WriteLine(FindReplaceString(S, indexes, sources, targets));
        }

        public string FindReplaceString(string S, int[] indexes, string[] sources, string[] targets)
        {
            string left, right;
            for (int i = 0; i < indexes.Length; i++)
            {
                if (S.Substring(indexes[i], sources[i].Length) != sources[i])
                    continue;
                left = indexes[i] == 0 ? "" : S.Substring(0, indexes[i]);
                right = indexes[i] + sources[i].Length == S.Length ? "" : S.Substring(indexes[i] + sources[i].Length);
                Console.WriteLine($"{left}\r\n{right}");
                indexes = Adjust(indexes, i, targets[i].Length - sources[i].Length);
                S = left + targets[i] + right;
            }
            return S;
        }

        private int[] Adjust(int[] nums, int compare, int adj)
        {
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] > nums[compare])
                    nums[i] += adj;
            return nums;
        }
    }
}

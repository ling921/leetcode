namespace P0601ToP0700
{
    /// <summary>
    /// 698. 划分为k个相等的子集
    /// </summary>
    public class Solution0698
    {
        public Solution0698()
        {
            var nums = "[4, 3, 2, 3, 5, 2, 1]".ToArray<int>();
            var k = 4;
            WriteLine(CanPartitionKSubsets(nums, k));
        }

        public bool CanPartitionKSubsets(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();
            var keys = new List<int>();
            int sum = 0, max = 0;
            foreach (var num in nums)
            {
                sum += num;
                max = Math.Max(max, num);
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict[num] = 1;
                    keys.Add(num);
                }
            }
            int avg = sum / k;
            if (sum % k != 0 || max > avg)
                return false;
            foreach (var key in keys)
            {
                if (key == 0 || key == avg)
                    continue;
                var i = dict[key];
                while (i > 0)
                {
                    if (dict.ContainsKey(avg - key) && dict[avg - key] > 0)
                    {
                        dict[key]--;
                        dict[avg - key]--;
                    }
                    else
                    {
                        return false;
                    }
                    i--;
                }
            }
            return true;
        }
    }
}

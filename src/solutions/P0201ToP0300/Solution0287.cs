namespace P0201ToP0300
{
    /// <summary>
    /// 287. Find the Duplicate Number
    /// </summary>
    public class Solution0287
    {
        public Solution0287()
        {
            int[] nums = { 1, 3, 4, 2, 2 };
            Console.WriteLine(FindDuplicate(nums));
            Console.Read();
        }

        public int FindDuplicate(int[] nums)
        {
            int fast = 0, slow = 0;
            while (true)
            {
                fast = nums[nums[fast]];
                slow = nums[slow];
                if (fast == slow)
                {
                    fast = 0;
                    while (fast != slow)
                    {
                        fast = nums[fast];
                        slow = nums[slow];
                    }
                    return fast;
                }
            }
        }
    }
}

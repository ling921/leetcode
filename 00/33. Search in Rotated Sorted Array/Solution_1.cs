namespace _33._Search_in_Rotated_Sorted_Array
{
    public class Solution_1
    {
        public int Search(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] == target)
                    return i;
            return -1;
        }
    }
}

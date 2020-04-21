namespace _55._Jump_Game
{
    class Solution_v1
    {
        public bool CanJump(int[] nums)
        {
            bool[] isAvaliable = new bool[nums.Length];
            isAvaliable[0] = true;
            for (int i = 0; i < nums.Length; i++)
                if (isAvaliable[i])
                    for (int j = 1; j <= nums[i] && i + j < nums.Length; j++)
                        isAvaliable[i + j] = true;
            return isAvaliable[nums.Length - 1];
        }
    }
}

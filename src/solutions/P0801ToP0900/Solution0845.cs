namespace P0801ToP0900
{
    /// <summary>
    /// 845. Longest Mountain in Array
    /// </summary>
    public class Solution0845
    {
        public Solution0845()
        {
            //int[] A = { 2, 1, 4, 7, 3, 2, 5 };
            //int[] A = { 2, 2, 2, 2, 2, 2, 2, 2 };
            //int[] A = { 0, 1, 2, 3, 4, 5, 4, 3, 2, 1, 0 };
            //int[] A = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] A = { 2, 1, 4, 7, 3, 2, 5 };
            //int[] A = { 2, 3, 3, 2, 0, 2 };
            //int[] A = { 875, 884, 239, 731, 723, 685 };
            //int[] A = { 0, 0, 1, 0, 0, 1, 1, 1, 1, 1 };
            Console.WriteLine(LongestMountain(A));
        }

        public int LongestMountain(int[] A)
        {
            if (A.Length < 3)
                return 0;
            int max = 0, count = 0;
            bool decrease = false;
            for (int i = 0; i < A.Length - 1; i++)
            {
                //顶部转折点,开启递减,并递减计数 ps:count不为0,说明已经递增过
                if (count != 0 && A[i] > A[i + 1])
                {
                    decrease = true;
                    count++;
                }
                //递增时计数,碰到相同数字,重置
                if (!decrease)
                    count = A[i] < A[i + 1] ? count + 1 : 0;
                //递减时到达山脚,结束递减
                else if (A[i] <= A[i + 1])
                {
                    decrease = false;
                    max = max > count + 1 ? max : count + 1;
                    count = A[i] == A[i + 1] ? 0 : 1;
                }
                //数组最后两个元素,若是处于递减状态
                if (i == A.Length - 2 && decrease && A[i] > A[i + 1])
                    max = max > count + 1 ? max : count + 1;
            }
            return max;
        }
    }
}

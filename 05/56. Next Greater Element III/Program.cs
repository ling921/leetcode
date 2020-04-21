using System;

namespace _56._Next_Greater_Element_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            //int n = 51432; //52134
            //int n = 52431; //53124
            int n = 12;
            Console.WriteLine(solution.NextGreaterElement(n));
            Console.ReadKey();
        }
    }
    /*
    1、从个位数向左定位到第一个高位小于低位的位置； 
    2、从低位中找出大于高位的最小值所在的位置； 
    3、交换1和2中两个位置的元素； 
    4、高位后元素升序排列。 
    注意：考虑到有可能转换之后的数大于int的最大值，故先将其转化成double类型的数。
    */
    public class Solution
    {
        public int NextGreaterElement(int n)
        {
            char[] num = n.ToString().ToCharArray();
            int high = -1, low = -1;
            for (int i = num.Length - 2; i >= 0; i--)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] < num[j])
                    {
                        high = i;
                        low = low == -1 ? j : (num[low] > num[j] ? j : low);
                    }
                }
                if (high != -1)
                {
                    char temp = num[high];
                    num[high] = num[low];
                    num[low] = temp;
                    Array.Sort(num, high + 1, num.Length - high - 1);
                    double newNum = double.Parse(new string(num));
                    if (newNum > int.MaxValue)
                        return -1;
                    else
                        return (int)newNum;
                }
            }
            return -1;
        }
    }
}
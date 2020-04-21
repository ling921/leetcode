using System;

namespace _05._Can_Place_Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1 }, 2));

            Console.Read();
        }
    }
    public class Solution
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int i = 0, len = flowerbed.Length;
            if (len == 1)
                return flowerbed[0] == 0 || n == 0;
            while (i < len && n > 0)
            {                
                if(flowerbed[i] == 0 && (
                   (i == 0 && flowerbed[i + 1] == 0) ||
                   (i == len - 1 && flowerbed[len - 2] == 0) ||
                   (i != 0 && i != len - 1 && flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)))
                {
                    n--;
                    flowerbed[i] = 1;
                }
                i++;
            }
            return n == 0;
        }
    }
}

namespace P0701ToP0800
{
    /// <summary>
    /// 717. 1-bit and 2-bit Characters
    /// </summary>
    public class Solution0717
    {
        public Solution0717()
        {
            Console.WriteLine();
        }

        public bool IsOneBitCharacter(int[] bits)
        {
            if (bits.Length == 1)
                return true;
            int index = 0;
            while (index < bits.Length - 1)
            {
                if (bits[index] == 1)
                    index += 2;
                else
                    index++;
            }
            return index == bits.Length - 1;
        }
    }
}

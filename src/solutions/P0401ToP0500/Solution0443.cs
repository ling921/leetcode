namespace P0401ToP0500
{
    /// <summary>
    /// 443. String Compression
    /// </summary>
    public class Solution0443
    {
        public Solution0443()
        {
            //char[] chars = { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            //char[] chars = { 'a', 'b', 'b' };
            //char[] chars = { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' };
            //char[] chars = { 'y', 'y', 'y', 'q', 'k', 'n', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c' };
            //char[] chars = { 'a', 'b', 'c' };
            char[] chars = { 'a', 'a', 'c' };
            Console.WriteLine(Compress(chars));
        }

        public int Compress(char[] chars)
        {
            if (chars.Length == 0)
                return 0;
            char key = chars[0];
            string str;
            int count = 0, index = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] != key)
                {
                    chars[index++] = key;
                    if (count != 1)
                    {
                        str = count.ToString();
                        Array.Copy(str.ToCharArray(), 0, chars, index, str.Length);
                        index += str.Length;
                    }
                    key = chars[i];
                    count = 1;
                }
                else
                    count++;
            }
            chars[index++] = key;
            if (count != 1)
            {
                str = count.ToString();
                Array.Copy(str.ToCharArray(), 0, chars, index, str.Length);
                index += str.Length;
            }
            return index;
        }
    }
}

using System;

namespace _25._Long_Pressed_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string name = "saeed";
            string typed = "ssaaedd";
            Console.WriteLine(solution.IsLongPressedName(name, typed));
            Console.Read();
        }
    }
    public class Solution
    {
        public bool IsLongPressedName(string name, string typed)
        {
            if (name.Length > typed.Length || name[name.Length - 1] != typed[typed.Length - 1])
                return false;
            int j = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] != typed[j])
                    return false;
                int count = 1;
                while (j < typed.Length && typed[j] == name[i])
                {
                    j++;
                    count--;
                }
                while (i < name.Length - 1 && name[i + 1] == name[i])
                {
                    i++;
                    count++;
                }
                if (count > 0)
                    return false;
            }
            if (j != typed.Length)
                return false;
            return true;
        }
    }
}

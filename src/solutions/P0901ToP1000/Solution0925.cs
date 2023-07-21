namespace P0901ToP1000
{
    /// <summary>
    /// 925. Long Pressed Name
    /// </summary>
    public class Solution0925
    {
        public Solution0925()
        {
            string name = "saeed";
            string typed = "ssaaedd";
            Console.WriteLine(IsLongPressedName(name, typed));
        }

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

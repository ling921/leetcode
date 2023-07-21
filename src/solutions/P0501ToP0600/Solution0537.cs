namespace P0501ToP0600
{
    /// <summary>
    /// 537. Complex Number Multiplication
    /// </summary>
    public class Solution0537
    {
        public Solution0537()
        {
            Console.WriteLine();
        }

        public string ComplexNumberMultiply(string a, string b)
        {
            int a1 = Convert.ToInt32(a.Split('+')[0]);
            int a2 = Convert.ToInt32(a.Split('+')[1].Replace("i", ""));
            int b1 = Convert.ToInt32(b.Split('+')[0]);
            int b2 = Convert.ToInt32(b.Split('+')[1].Replace("i", ""));
            return $"{a1 * b1 - a2 * b2}+{a1 * b2 + a2 * b1}i";
        }
    }
}

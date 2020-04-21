using System;

namespace _37._Complex_Number_Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
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

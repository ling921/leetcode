using System;

namespace P0601ToP0700
{
    /// <summary>
    /// 640. Solve the Equation
    /// </summary>
    public class Solution0640
    {
        public Solution0640()
        {
            string equation = "-x=-1";
            Console.WriteLine(SolveEquation(equation));
        }

        public string SolveEquation(string equation)
        {
            string[] eq = equation.Split('=');
            eq[0] = (eq[0][0] == '-' ? "" : "+") + eq[0] + "+";
            eq[1] = (eq[1][0] == '-' ? "" : "+") + eq[1] + "+";
            int xSum = 0, numSum = 0, index = 0;
            for (int i = 1; i < eq[0].Length; i++)
            {
                if (eq[0][i] == '-' || eq[0][i] == '+')
                {
                    string str = eq[0].Substring(index, i - index);
                    if (str[str.Length - 1] == 'x')
                    {
                        if (str.Length == 2)
                            xSum += str[0] == '+' ? 1 : -1;
                        else
                            xSum += (str[0] == '+' ? 1 : -1) * int.Parse(str.Substring(1, str.Length - 2));
                    }
                    else
                        numSum += (str[0] == '+' ? -1 : 1) * int.Parse(str.Substring(1, str.Length - 1));
                    index = i;
                }
            }
            index = 0;
            for (int i = 1; i < eq[1].Length; i++)
            {
                if (eq[1][i] == '-' || eq[1][i] == '+')
                {
                    string str = eq[1].Substring(index, i - index);
                    if (str[str.Length - 1] == 'x')
                    {
                        if (str.Length == 2)
                            xSum += str[0] == '+' ? -1 : 1;
                        else
                            xSum += (str[0] == '+' ? -1 : 1) * int.Parse(str.Substring(1, str.Length - 2));
                    }
                    else
                        numSum += (str[0] == '+' ? 1 : -1) * int.Parse(str.Substring(1, str.Length - 1));
                    index = i;
                }
            }
            if (xSum == 0 && numSum == 0)
                return "Infinite solutions";
            else if (xSum == 0 && numSum != 0)
                return "No solution";
            else
                return $"x={numSum / xSum}";
        }
    }
}

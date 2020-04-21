using System.Text.RegularExpressions;

namespace _40._Solve_the_Equation
{
    class Solution_1
    {
        public string SolveEquation(string equation)
        {
            if (equation.Length < 3)
                return null;
            string leftEquation, rightEquation;
            leftEquation = "+" + equation.Split('=')[0];
            rightEquation = "+" + equation.Split('=')[1];
            MatchCollection[] x = new MatchCollection[2];
            MatchCollection[] num = new MatchCollection[2];
            x[0] = Regex.Matches(leftEquation, "-?\\d{0,}x");
            leftEquation = Regex.Replace(leftEquation, "\\+\\d{0,}x", string.Empty);
            leftEquation = Regex.Replace(leftEquation, "-\\d{0,}x", string.Empty);

            x[1] = Regex.Matches(rightEquation, "-?\\d{0,}x");
            rightEquation = Regex.Replace(rightEquation, "\\+\\d{0,}x", string.Empty);
            rightEquation = Regex.Replace(rightEquation, "-\\d{0,}x", string.Empty);

            num[0] = Regex.Matches(leftEquation, @"-?\d+");
            num[1] = Regex.Matches(rightEquation, @"-?\d+");

            int xSum = CalcX(x[0]) - CalcX(x[1]);
            int numSum = -CalcNum(num[0]) + CalcNum(num[1]);
            if (xSum == 0 && numSum == 0)
                return "Infinite solutions";
            else if (xSum == 0 && numSum != 0)
                return "No solution";
            else
                return $"x={numSum / xSum}";
        }
        public int CalcNum(MatchCollection collection)
        {
            int sum = 0;
            foreach (var num in collection)
                sum += int.Parse(num.ToString());
            return sum;
        }
        public int CalcX(MatchCollection collection)
        {
            int sum = 0;
            foreach (var num in collection)
            {
                string str = num.ToString();
                if (str == "x")
                    sum += 1;
                else if (str == "-x")
                    sum += -1;
                else
                    sum += int.Parse(str.Substring(0, str.Length - 1));
            }
            return sum;
        }
    }
}
using System;

namespace _57._Robot_Return_to_Origin
{
    class Program
    {
        static void Main(string[] args)
        {
            string moves = "UD";
            Solution solution = new Solution();
            Console.WriteLine(solution.JudgeCircle(moves));
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public bool JudgeCircle(string moves)
        {
            int[] count = new int[4];
            for (int i = 0; i < moves.Length; i++)
            {
                switch (moves[i])
                {
                    case 'R':
                        count[0]++;
                        break;
                    case 'L':
                        count[1]++;
                        break;
                    case 'U':
                        count[2]++;
                        break;
                    case 'D':
                        count[3]++;
                        break;
                    default:
                        break;
                }
            }
            return count[0] == count[1] && count[2] == count[3];
        }
    }
}

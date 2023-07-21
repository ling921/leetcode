namespace P0601ToP0700
{
    /// <summary>
    /// 657. Robot Return to Origin
    /// </summary>
    public class Solution0657
    {
        public Solution0657()
        {
            string moves = "UD";
            Console.WriteLine(JudgeCircle(moves));
        }

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

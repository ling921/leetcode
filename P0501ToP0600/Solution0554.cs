using static CommonLibrary.Extensions.ConsoleExtension;
using CommonLibrary.Extensions;
using System.Collections.Generic;

namespace P0501ToP0600
{
    /// <summary>
    /// 554. 砖墙
    /// </summary>
    public class Solution0554
    {
        public Solution0554()
        {
            var wall = @"[[1,2,2,1],
      [3,1,2],
      [1,3,2],
      [2,4],
      [3,1,2],
      [1,3,1,1]]".ToJaggedList<int>();
            WriteLine(LeastBricks(wall));
        }

        public int LeastBricks(IList<IList<int>> wall)
        {
            var dict = new Dictionary<int, int>();
            int sum, max = 0;
            for (int i = 0; i < wall.Count; i++)
            {
                sum = 0;
                for (int j = 0; j < wall[i].Count - 1; j++)
                {
                    sum += wall[i][j];
                    if (dict.ContainsKey(sum))
                        dict[sum]++;
                    else
                        dict[sum] = 1;
                }
            }
            foreach (var (_, v) in dict)
            {
                max = max >= v ? max : v;
            }
            return wall.Count - max;
        }
    }
}
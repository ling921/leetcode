using CommonLibrary;
using System;
using System.Collections.Generic;

namespace P0401ToP0500
{
    /// <summary>
    /// 406. Queue Reconstruction by Height
    /// </summary>
    public class Solution0406
    {
        public Solution0406()
        {
            //int[,] people = new int[,] { { 7, 0 }, { 4, 4 }, { 7, 1 }, { 5, 0 }, { 6, 1 }, { 5, 2 } };
            //int[,] people = new int[,] {{2, 4},{3, 4},{9, 0},{0, 6},{7, 1},{6, 0},{7, 3},{2, 5},{1, 1},{8, 0}};
            int[,] people = new int[,] { { 2, 4 }, { 3, 4 }, { 9, 0 }, { 0, 6 }, { 7, 1 }, { 6, 0 }, { 7, 3 }, { 2, 5 }, { 1, 1 }, { 8, 0 } };

            int[,] sort = ReconstructQueue(people);

            sort.Print();
        }

        /// <summary>
        /// <para>
        /// 假设有打乱顺序的一群人站成一个队列。 每个人由一个整数对(h, k)表示，其中h是这个人的身高，k是排在这个人前面且身高大于或等于h的人数。 编写一个算法来重建这个队列。
        /// 注意： 总人数少于1100人。 示例 输入: [[7,0], [4,4], [7,1], [5,0], [6,1], [5,2]] 输出: [[5,0], [7,0],
        /// [5,2], [6,1], [4,4], [7,1]]
        /// </para>
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public int[,] ReconstructQueue(int[,] people)
        {
            List<Tuple<int, int>> temp = new List<Tuple<int, int>>();
            for (int i = 0; i < people.GetLength(0); i++)
            {
                int count = 0;
                for (int j = 0; j < people.GetLength(0); j++)
                {
                    if (people[i, 1] == count)
                    {
                        if (temp.Count > j + 1)
                            temp.Insert(j, new Tuple<int, int>(people[i, 0], people[i, 1]));
                        else if (temp[j - 1].Item1 == -1)
                            temp[j - 1] = new Tuple<int, int>(people[i, 0], people[i, 1]);
                        else
                            temp.Add(new Tuple<int, int>(people[i, 0], people[i, 1]));
                        break;
                    }
                    else
                    {
                        while (temp.Count < people[i, 1])
                            temp.Add(new Tuple<int, int>(-1, -1));
                        if (temp[j].Item1 > people[i, 0] || temp[j].Item1 == -1)
                            count++;
                    }
                }
            }
            for (int i = 0; i < people.GetLength(0); i++)
            {
                people[i, 0] = temp[i].Item1;
                people[i, 1] = temp[i].Item2;
            }
            return people;
        }
    }
}

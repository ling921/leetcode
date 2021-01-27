using System;
using System.Collections.Generic;
using System.Linq;

namespace P0801ToP0900
{
    /// <summary>
    /// 841. Keys and Rooms
    /// </summary>
    public class Solution0841
    {
        public Solution0841()
        {
            IList<IList<int>> rooms = new List<IList<int>>();
            rooms.Add(new List<int>() { 1 });
            rooms.Add(new List<int>() { 2 });
            rooms.Add(new List<int>() { });
            rooms.Add(new List<int>() { 3 });
            Console.WriteLine(CanVisitAllRooms(rooms));
        }

        /*执行用时: 160 ms, 在Keys and Rooms的C#提交中击败了77.78% 的用户*/

        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            bool[] keys = new bool[rooms.Count];
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(0);
            int count = 0;
            while (queue.Count != 0)
            {
                int key = queue.Dequeue();
                if (!keys[key])
                {
                    keys[key] = true;
                    count++;
                    rooms[key].ToList().ForEach(item => { queue.Enqueue(item); });
                }
            }
            if (count == rooms.Count)
                return true;
            else
                return false;
        }
    }
}

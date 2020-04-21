using System.Collections.Generic;

namespace _41._Keys_and_Rooms
{
    class Solution_1
    {
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            int len = rooms.Count;
            keys = new bool[len];
            keys[0] = true;
            OpenDoor(0, rooms);
            for (int i = 0; i < len; i++)
                if (!keys[i])
                    return false;
            return true;
        }
        private bool[] keys;
        private void OpenDoor(int key, IList<IList<int>> rooms)
        {
            foreach (int item in rooms[key])
            {
                if (!keys[item])
                {
                    keys[item] = true;
                    OpenDoor(item, rooms);
                }
            }
        }
    }
}

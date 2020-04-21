namespace _06._Queue_Reconstruction_by_Height
{
    public class Solution_1
    {
        public int[,] ReconstructQueue(int[,] people)
        {
            int[,] newPeople = new int[people.GetLength(0), 2];
            for (int i = 0; i < people.GetLength(0); i++)
                newPeople[i, 1] = -1;
            QuickSort(people, 0, people.GetLength(0) - 1);
            for (int i = 0; i < people.GetLength(0); i++)
            {
                int countEmpty = 0;
                for (int j = 0; j < people.GetLength(0); j++)
                {
                    if (newPeople[j, 1] == -1 && countEmpty == people[i, 1])
                    {
                        newPeople[j, 0] = people[i, 0];
                        newPeople[j, 1] = people[i, 1];
                        break;
                    }
                    if (newPeople[j, 1] == -1 || newPeople[j, 0] == people[i, 0])
                        countEmpty++;
                }
            }
            return newPeople;
        }

        /// <summary>
        /// 二维数组按照第一维度升序排序
        /// </summary>
        /// <param name="array">二维int数组</param>
        /// <param name="startIndex">排序开始位置</param>
        /// <param name="lastIndex">排序结束位置</param>
        public static void QuickSort(int[,] array, int startIndex, int lastIndex)
        {
            if (startIndex >= lastIndex)
                return;
            int[] key = new int[2] { array[startIndex, 0], array[startIndex, 1] };
            int i = startIndex, j = lastIndex;
            while (i < j)
            {
                while (i < j && array[j, 0] >= key[0])
                    j--;
                array[i, 0] = array[j, 0];
                array[i, 1] = array[j, 1];
                while (i < j && array[i, 0] <= key[0])
                    i++;
                array[j, 0] = array[i, 0];
                array[j, 1] = array[i, 1];
            }
            array[i, 0] = key[0];
            array[i, 1] = key[1];
            QuickSort(array, startIndex, i - 1);
            QuickSort(array, i + 1, lastIndex);
        }
    }
}

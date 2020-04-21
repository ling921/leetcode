using System;

namespace _36._Valid_Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public bool IsValidSudoku(char[,] board)
        {
            for (int i = 0; i < 9; i++)
                if (!IsRowOrColumnValid(board, i) || !IsSubBoxValid(board, new int[2] { i % 3 * 3, i / 3 * 3 }))
                    return false;
            return true;
        }
        private bool IsRowOrColumnValid(char[,] board, int index)
        {
            int[][] temp = new int[2][] { new int[9], new int[9] };
            for (int i = 0; i < 9; i++)
            {
                char c1 = board[index, i];
                char c2 = board[i, index];
                if (c1 != '.')
                    temp[0][c1 - 1]++;
                if (c2 != '.')
                    temp[1][c2 - 1]++;
                if (temp[0][c1 - 1] == 2 || temp[1][c2 - 1] == 2)
                    return false;
            }
            return true;
        }
        private bool IsSubBoxValid(char[,] board, int[] start)
        {
            int[] temp = new int[9];
            for (int i = 0; i < 9; i++)
            {
                char c = board[start[0] + i / 3, start[1] + i % 3];
                if (c != '.')
                    temp[c - 1]++;
                if (temp[c - 1] == 2)
                    return false;
            }
            return true;
        }
    }
}

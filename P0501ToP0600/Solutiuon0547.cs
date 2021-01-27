using System;

namespace P0501ToP0600
{
    /// <summary>
    /// 547. Friend Circles
    /// </summary>
    public class Solutiuon0547
    {
        public Solutiuon0547()
        {
            Console.WriteLine();
        }

        public int FindCircleNum(int[,] M)
        {
            int count = 0;
            int len = M.GetLength(0);
            for (int i = 0; i < len; i++)
            {
                for (int j = i; j < len; j++)
                {
                    if (M[i, j] == 1)
                    {
                        count++;
                        if (i == j)
                            SetFindCircle(M, i);
                        else
                        {
                            SetFindCircle(M, i);
                            SetFindCircle(M, j);
                        }
                        break;
                    }
                }
            }
            return count;
        }

        private void SetFindCircle(int[,] M, int index)
        {
            for (int i = 0; i < M.GetLength(0); i++)
            {
                if (M[index, i] == 1)
                {
                    M[index, i] = M[i, index] = 0;
                    SetFindCircle(M, i);
                }
            }
        }
    }
}

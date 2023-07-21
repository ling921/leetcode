namespace P0701ToP0800
{
    /// <summary>
    /// 775. Global and Local Inversions
    /// </summary>
    public class Solution0775
    {
        public Solution0775()
        {
            int[] A = new int[] { };
            Console.WriteLine(IsIdealPermutation(A));
        }

        public bool IsIdealPermutation(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
                if (Math.Abs(A[i] - i) > 1)
                    return false;
            return true;
        }
    }
}

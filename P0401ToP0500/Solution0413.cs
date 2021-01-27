namespace P0401ToP0500
{
    /// <summary>
    /// 413. Arithmetic Slices
    /// </summary>
    public class Solution0413
    {
        public Solution0413()
        {
        }

        private int[] Slices { get; set; }

        public int NumberOfArithmeticSlices(int[] A)
        {
            Slices = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
            }

            return default;
        }

        private int GetSlicesFromLength(int len)
        {
            if (len < 3)
                return 0;
            if (len == 3)
                return 1;
            if (Slices[len - 1] == 0)
                Slices[len - 1] = GetSlicesFromLength(len - 1) + len - 2;
            return Slices[len - 1];
        }
    }
}

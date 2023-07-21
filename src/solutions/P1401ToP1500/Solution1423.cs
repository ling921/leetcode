namespace P1401ToP1500
{
    public class Solution1423
    {
        public Solution1423()
        {
        }

        public int MaxScore(int[] cardPoints, int k)
        {
            var sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += cardPoints[i];
            }
            var max = sum;
            for (int i = 0; i < k; i++)
            {
                sum += cardPoints[cardPoints.Length - i - 1] - cardPoints[k - i - 1];
                max = Math.Max(max, sum);
            }
            return max;
        }
    }
}

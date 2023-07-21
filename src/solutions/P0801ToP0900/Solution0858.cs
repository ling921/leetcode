namespace P0801ToP0900
{
    public class Solution0858
    {
        public Solution0858()
        {
        }

        public int MirrorReflection(int p, int q)
        {
            while ((p & 1) == 0 && (q & 1) == 0)
            {
                p >>= 1;
                q >>= 1;
            }
            if ((q & 1) == 0)
                return 0;
            if ((p & 1) == 0)
                return 2;
            return 1;
        }
    }
}

namespace P1101ToP1200
{
    public class Solution1117
    {
        public Solution1117()
        {
            var str = "OOHHHH";
            var h2O = new H2O();
        }

        public class H2O
        {
            private SemaphoreSlim _hydrogenSema = new SemaphoreSlim(2, 2);

            private SemaphoreSlim _oxygenSema = new SemaphoreSlim(0, 1);

            public H2O()
            {
            }

            public void Hydrogen(Action releaseHydrogen)
            {
                _hydrogenSema.Wait();
                releaseHydrogen();
                if (_hydrogenSema.CurrentCount == 0)
                {
                    _oxygenSema.Release();
                }
            }

            public void Oxygen(Action releaseOxygen)
            {
                _oxygenSema.Wait();
                releaseOxygen();
                _hydrogenSema.Release(2);
            }
        }
    }
}

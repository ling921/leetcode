namespace P1101ToP1200
{
    /// <summary>
    /// 1195. 交替打印字符串
    /// </summary>
    public class Solution1195
    {
        public Solution1195()
        {
        }

        public class FizzBuzz
        {
            private int n;
            private AutoResetEvent event_FizzBuzz = new AutoResetEvent(false);
            private AutoResetEvent event_Fizz = new AutoResetEvent(false);
            private AutoResetEvent event_Buzz = new AutoResetEvent(false);
            private AutoResetEvent event_number = new AutoResetEvent(false);

            public FizzBuzz(int n)
            {
                this.n = n;
            }

            // printFizz() outputs "fizz".
            public void Fizz(Action printFizz)
            {
                var count = n / 3 - n / 15;
                for (var i = 0; i < count; i++)
                {
                    event_Fizz.WaitOne();
                    printFizz();
                    event_number.Set();
                }
            }

            // printBuzzz() outputs "buzz".
            public void Buzz(Action printBuzz)
            {
                var count = n / 5 - n / 15;
                for (var i = 0; i < count; i++)
                {
                    event_Buzz.WaitOne();
                    printBuzz();
                    event_number.Set();
                }
            }

            // printFizzBuzz() outputs "fizzbuzz".
            public void Fizzbuzz(Action printFizzBuzz)
            {
                var count = n / 15;
                for (var i = 0; i < count; i++)
                {
                    event_FizzBuzz.WaitOne();
                    printFizzBuzz();
                    event_number.Set();
                }
            }

            // printNumber(x) outputs "x", where x is an integer.
            public void Number(Action<int> printNumber)
            {
                for (var i = 1; i <= n; i++)
                {
                    if (i % 15 == 0)
                    {
                        event_FizzBuzz.Set();
                        event_number.WaitOne();
                    }
                    else if (i % 3 == 0)
                    {
                        event_Fizz.Set();
                        event_number.WaitOne();
                    }
                    else if (i % 5 == 0)
                    {
                        event_Buzz.Set();
                        event_number.WaitOne();
                    }
                    else
                    {
                        printNumber(i);
                    }
                }
            }
        }
    }
}

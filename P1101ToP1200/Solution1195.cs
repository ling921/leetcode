using System;
using System.Threading;

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
            private SemaphoreSlim _SemaphoreFizz = new SemaphoreSlim(0, 1);
            private SemaphoreSlim _SemaphoreBuzz = new SemaphoreSlim(0, 1);
            private SemaphoreSlim _SemaphoreFizzbuzz = new SemaphoreSlim(0, 1);
            private SemaphoreSlim _SemaphoreNumber = new SemaphoreSlim(1, 1);

            public FizzBuzz(int n)
            {
                this.n = n;
            }

            // printFizz() outputs "fizz".
            public void Fizz(Action printFizz)
            {
                for (int i = 1; i < n + 1; i++)
                {
                    if (i % 3 == 0 && i % 5 != 0)
                    {
                        _SemaphoreFizz.Wait();
                        printFizz();
                        _SemaphoreNumber.Release();
                    }
                }
            }

            // printBuzzz() outputs "buzz".
            public void Buzz(Action printBuzz)
            {
                for (int i = 1; i < n + 1; i++)
                {
                    if (i % 5 == 0 && i % 3 != 0)
                    {
                        _SemaphoreBuzz.Wait();
                        printBuzz();
                        _SemaphoreNumber.Release();
                    }
                }
            }

            // printFizzBuzz() outputs "fizzbuzz".
            public void Fizzbuzz(Action printFizzBuzz)
            {
                for (int i = 1; i < n + 1; i++)
                {
                    if (i % 15 == 0)
                    {
                        _SemaphoreFizzbuzz.Wait();
                        printFizzBuzz();
                        _SemaphoreNumber.Release();
                    }
                }
            }

            // printNumber(x) outputs "x", where x is an integer.
            public void Number(Action<int> printNumber)
            {
                for (int i = 1; i < n + 1; i++)
                {
                    _SemaphoreNumber.Wait();
                    if (i % 15 == 0)
                    {
                        _SemaphoreFizzbuzz.Release();
                    }
                    else if (i % 5 == 0)
                    {
                        _SemaphoreBuzz.Release();
                    }
                    else if (i % 3 == 0)
                    {
                        _SemaphoreFizz.Release();
                    }
                    else
                    {
                        printNumber(i);
                        _SemaphoreNumber.Release();
                    }
                }
            }
        }
    }
}

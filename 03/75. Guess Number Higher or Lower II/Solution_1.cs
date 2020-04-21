using System;
using System.Linq;

namespace _75._Guess_Number_Higher_or_Lower_II
{
    public class Solution_1
    {
        public int GetMoneyAmount(int n)
        {
            MoneyAmounts = new int[n + 1, n + 1];
            return MinMoney(1, n);
        }
        public int[,] MoneyAmounts;
        private int MinMoney(int startNum, int endNum)
        {
            if (endNum - startNum <= 0)
                return 0;
            else if (endNum - startNum == 1)
                return startNum;
            else if (endNum - startNum == 2)
                return startNum + 1;

            if (MoneyAmounts[startNum, endNum] == 0)
            {
                int[] money = new int[endNum - startNum - 1];
                for (int i = startNum + 1; i < endNum; i++)
                {
                    MoneyAmounts[startNum, i - 1] = MoneyAmounts[startNum, i - 1] == 0 ? MinMoney(startNum, i - 1) : MoneyAmounts[startNum, i - 1];
                    MoneyAmounts[i + 1, endNum] = MoneyAmounts[i + 1, endNum] == 0 ? MinMoney(i + 1, endNum) : MoneyAmounts[i + 1, endNum];
                    money[i - startNum - 1] = i + Math.Max(MoneyAmounts[startNum, i - 1], MoneyAmounts[i + 1, endNum]);
                }
                MoneyAmounts[startNum, endNum] = money.Min();
            }
            return MoneyAmounts[startNum, endNum];
        }
    }
}
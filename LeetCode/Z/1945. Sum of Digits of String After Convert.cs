using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1945
    {

        public static int GetLucky(string s, int k)
        {
            var sumList = new List<int>();

            for (int i = 0; i < s.Length; i++)
            {
                sumList.Add(s[i] - 96);
            }
            var SumVal = 0;
            foreach (var item in sumList)
            {
                SumVal += GetDigitSum(item);
            }
            for (int j = 1; j < k; j++)
            {
                SumVal = GetDigitSum(SumVal);
            }
            return SumVal;
        }

        public static int GetDigitSum(int num)
        {
            var sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }
}

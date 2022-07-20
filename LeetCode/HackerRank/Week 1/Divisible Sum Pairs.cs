using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.Week_1
{
    internal class Divisible_Sum_Pairs
    {
        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            var counter = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
    }
}

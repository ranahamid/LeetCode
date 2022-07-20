using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.Mock
{
    internal class Find_the_Median
    {
        public static int findMedian(List<int> arr)
        {
            arr.Sort();
            var len = arr.Count();
            if (len % 2 == 1)
            {
                var half = len / 2;
                return arr[half];
            }
            else
            {
                var half = len / 2;
                var halfOne = half + 1;
                var sum = arr[half] + arr[halfOne];
                return sum / 2;
            }
        }
    }
}

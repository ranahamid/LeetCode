using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.Greedy
{
    internal class Minimum_Absolute_Difference_in_an_Array
    {
        public static int minimumAbsoluteDifference(List<int> arr)
        {
            arr.Sort();
            var min = Int32.MaxValue;
            for (int i = 1; i < arr.Count; i++)
            {
                var diff = Math.Abs(arr[i] - arr[i - 1]);
                min = Math.Min(min, diff);
            }
            return min;
        }

    }
}

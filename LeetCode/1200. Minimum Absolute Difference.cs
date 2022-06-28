using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _1200__Minimum_Absolute_Difference {
        /// <summary>
        /// Runtime: 270 ms, faster than 55.81% of C# online submissions for Minimum Absolute Difference.
        /// Memory Usage: 50.7 MB, less than 46.51% of C# online submissions for Minimum Absolute Difference.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public IList<IList<int>> MinimumAbsDifference(int[] arr) {
            List<IList<int>> result = new List<IList<int>>();
            Array.Sort(arr);
            var min = Int32.MaxValue;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (i + 1 < arr.Length)
                {
                    var diff = arr[i + 1] - arr[i];
                    if (diff <= min)
                    {
                        List<int> data = new List<int>();
                        data.Add(arr[i]);data.Add(arr[i+1]);
                        result.Add(data);
                        //i++;
                        min = diff;
                    }
                }
            }
            List<IList<int>> result2 = new List<IList<int>>();
            var minDiff = Int32.MaxValue;
            foreach (var item in result)
            {
                var diff = Math.Abs(item[0] - item[1]);
                minDiff = Math.Min(minDiff, diff);
            }
            foreach (var item in result)
            {
                var diff = Math.Abs(item[0] - item[1]);
                if (minDiff == diff)
                {
                    result2.Add(item);
                } 
            }

            return result2;
        }
    }
}
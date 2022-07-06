using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _128__Longest_Consecutive_Sequence 
    {
        /// <summary>
        /// Runtime: 575 ms, faster than 7.92% of C# online submissions for Longest Consecutive Sequence.
        /// Memory Usage: 45.4 MB, less than 78.21% of C# online submissions for Longest Consecutive Sequence.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int LongestConsecutive(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            var maxVal = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                var x = nums[i];
                if (!set.Contains(x - 1))
                {
                    var y = x + 1;
                    while (set.Contains(y))
                    {
                        y++;
                    }
                    maxVal = Math.Max(maxVal, y - x);
                }
            }
            return maxVal;
        }
        
        
        /// <summary>
        /// Runtime: 204 ms, faster than 72.51% of C# online submissions for Longest Consecutive Sequence.
        /// Memory Usage: 45.7 MB, less than 77.19% of C# online submissions for Longest Consecutive Sequence.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int LongestConsecutive_2(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            if (nums.Length == 1)
                return 1;
            HashSet<int> set = new HashSet<int>(nums);
            var list = set.ToArray();
            Array.Sort(list);
            var maxVal = 0;
            var counter = 0;
            for (int i = 1; i < list.Length; i++)
            {
                if (list[i]  == list[i-1]+ 1 )
                {
                    counter++;
                    maxVal = Math.Max(counter +1 , maxVal);
                }
                else
                {
                    counter = 0;
                }
            }
            return maxVal==0?1:maxVal;
        }

    }
}
using System;
using System.Collections.Generic;
namespace LeetCode
{
    public class _1051_Height_Checker
    {
        
        /// <summary>
        /// Runtime: 91 ms, faster than 86.61% of C# online submissions for Height Checker.
        /// Memory Usage: 38.4 MB, less than 8.93% of C# online submissions for Height Checker.
        /// </summary>
        /// <param name="heights"></param>
        /// <returns></returns>
        public static  int HeightChecker(int[] heights)
        {
            var sort = new int[heights.Length];
            for (int i = 0; i < heights.Length; i++)
            {
                sort[i] = heights[i];
            }
            Array.Sort(sort);
            var counter = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                if (sort[i] != heights[i])
                    counter++;
            }

            return counter;

        }


    }
}
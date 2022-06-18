using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _704
    {

        /// <summary>
        /// Runtime: 173 ms, faster than 44.69% of C# online submissions for Binary Search.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int Search(int[] nums, int target)
        {
            var start = 0;
            var end = nums.Length - 1;
            while (start <= end)
            {
                var mid = (end + start) / 2;
                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return -1;
        }


        /// <summary>
        /// Runtime: 146 ms, faster than 68.02% of C# online submissions for Binary Search.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int Search_2(int[] nums, int target)
        {
            var start = 0;
            var end = nums.Length - 1;
            while (start <= end)
            {
                var mid = (int)Math.Floor((double)(end + start) / 2);
                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] > target)
                {
                    end--; //self made algo
                }
                else
                {
                    start++; //self made algo
                }
            }
            return -1;
        }
    }
}

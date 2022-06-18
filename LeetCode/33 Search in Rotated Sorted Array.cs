using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _33_Search_in_Rotated_Sorted_Array
    {

        /// <summary>
        /// Runtime: 95 ms, faster than 77.61% of C# online submissions for Search in Rotated Sorted Array.
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
                ///left part is sorted
                if (nums[start] <= nums[mid])
                {
                    if (target >= nums[start] && target < nums[mid])
                    {
                        //left part 
                        end = mid - 1; //eliminate right part 
                    }
                    else
                    {
                        //right partt
                        start = mid + 1; //eliminate left part
                    }
                }
                else
                {
                    if (target > nums[mid] && target <= nums[end])
                    {

                        start = mid + 1; //eliminate left part
                    }
                    else
                    {
                        end = mid - 1;//eliminate right part 
                    }
                }

            }
            return -1;
        }
        /// <summary>
        /// Runtime: 74 ms, faster than 99.51% of C# online submissions for Search in Rotated Sorted Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int Search_2(int[] nums, int target)
        {
            var start = 0;
            var end = nums.Length - 1;
            while (start <= end)
            {
                var mid = (end + start) / 2;
                if (nums[mid] == target)
                    return mid;
                if (nums[start] <= nums[mid])
                {
                    if (target > nums[mid] || target < nums[start])
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
                else
                {
                    if (target < nums[mid] || target > nums[end])
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }

            }
            return -1;
        }
    }
}

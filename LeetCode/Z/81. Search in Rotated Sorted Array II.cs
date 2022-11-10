using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _81
    {
        /// <summary>
        /// Runtime: 104 ms, faster than 90.00% of C# online submissions for Search in Rotated Sorted Array II.
        /// Memory Usage: 41.4 MB, less than 11.43% of C# online submissions for Search in Rotated Sorted Array II.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool Search(int[] nums, int target)
        {
            var start = 0;
            var end = nums.Length - 1;
            while (start <= end)
            {
                while (start < end && nums[start] == nums[start + 1])
                    start++;
                while (start < end && nums[end] == nums[end - 1])
                    end--;


                var mid = (end + start) / 2;
                if (nums[mid] == target)
                    return true;
                ///left part is sorted
                if (nums[start] <= nums[mid])
                {
                    if (target >= nums[start] && target < nums[mid])
                    {
                        //left part 
                        end = mid - 1;
                    }
                    else
                    {
                        //right partt
                        start = mid + 1;
                    }
                }
                else
                {
                    if (target > nums[mid] && target <= nums[end])
                    {

                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }

            }
            return false;
        }
        /// <summary>
        /// Runtime: 132 ms, faster than 65.71% of C# online submissions for Search in Rotated Sorted Array II.
        /// Memory Usage: 39.9 MB, less than 45.71% of C# online submissions for Search in Rotated Sorted Array II.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool Search_1(int[] nums, int target)
        {
            return nums.Count(x => x == target) > 0;
        }
    }
}

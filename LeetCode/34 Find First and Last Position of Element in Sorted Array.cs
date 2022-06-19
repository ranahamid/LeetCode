using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _34_Find_First_and_Last_Position_of_Element_in_Sorted_Array
    {
        #region optimal solution
        /// <summary>
        /// Runtime: 238 ms, faster than 23.23% of C# online submissions for Find First and Last Position of Element in Sorted Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] SearchRange(int[] nums, int target)
        {
            int first = BinarySearch(nums, target, start: 0, end: nums.Length - 1);
            if (first == -1)
                return new int[2] { -1, -1 };
            int left = first;
            while (left > 0 && nums[left - 1] == target)
            {
                left = BinarySearch(nums, target, start: 0, end: left - 1);
            }
            int right = first;
            while (right < nums.Length - 1 && nums[right + 1] == target)
            {
                right = BinarySearch(nums, target, start: right + 1, end: nums.Length - 1);
            }
            return new int[2] { left, right };
        }
        public static int BinarySearch(int[] nums, int target, int start, int end)
        {
            //var start = 0;
            //var end = nums.Length - 1;
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
        #endregion
        #region algo tutorial
        /// <summary>
        /// Runtime: 304 ms, faster than 5.24% of C# online submissions for Find First and Last Position of Element in Sorted Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] SearchRange_3(int[] nums, int target)
        {
            int[] result = new int[2] { -1, -1 };
            if (nums.Length == 0)
            {
                return result;
            }
            LeftPartIndex(nums, target, result, 0, nums.Length - 1);
            RightPartIndex(nums, target, result, 0, nums.Length - 1);
            return result;
        }
        public static void LeftPartIndex(int[] nums, int target, int[] result, int left, int right)
        {
            if (left > right)
                return;
            var mid = (left + right) / 2;
            if (nums[mid] == target)
            {
                if (mid == 0)
                {
                    result[0] = mid;
                }
                else if (nums[mid - 1] == target)
                {
                    //explore left part
                    LeftPartIndex(nums, target, result, left, mid - 1);
                }
                else
                {
                    result[0] = mid;
                }
            }
            else if (nums[mid] > target)
            {
                LeftPartIndex(nums, target, result, left, mid - 1);
            }
            else
            {
                LeftPartIndex(nums, target, result, mid + 1, right);
            }
        }

        public static void RightPartIndex(int[] nums, int target, int[] result, int left, int right)
        {

            if (left > right)
                return;
            var mid = (left + right) / 2;
            if (nums[mid] == target)
            {

                if (mid == nums.Length - 1)
                {
                    result[1] = mid;
                }
                else if (nums[mid + 1] == target)
                {
                    //explore left part
                    RightPartIndex(nums, target, result, mid + 1, right);
                }
                else
                {
                    result[1] = mid;
                }
            }
            else if (nums[mid] > target)
            {
                RightPartIndex(nums, target, result, left, mid - 1);
            }
            else
            {
                RightPartIndex(nums, target, result, mid + 1, right);
            }
        }
        #endregion
        #region Self made algo
        /// <summary>
        /// 203 ms
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] SearchRange_2(int[] nums, int target)
        {
            var start = 0;
            var end = nums.Length - 1;
            int[] result = new int[2];
            result[0] = -1;
            result[1] = -1;
            bool leftCOm = false, rightCOm = false;
            if (nums.Length == 0)
            {
                return result;
            }
            if (nums.Length == 1 && nums.Contains(target))
            {
                result[0] = 0;
                result[1] = 0;
                return result;
            }
            while (start <= end)
            {
                if (leftCOm && rightCOm)
                    return result;
                var mid = (end + start) / 2;
                if (nums[mid] == target)
                {
                    result[0] = mid;
                    result[1] = mid;
                    if (mid == 0)
                    {
                        leftCOm = true;
                    }
                    else if (nums[mid - 1] == target)
                    {
                        //explore left part
                        result[0] = LeftPart(nums, target, mid - 1); leftCOm = true;
                        if (leftCOm && rightCOm)
                            return result;
                    }
                    else
                    {
                        leftCOm = true;
                    }

                    if (mid == nums.Length - 1)
                    {
                        result[1] = mid; rightCOm = true;
                    }

                    else if (nums[mid + 1] == target)
                    {
                        //explore right 
                        result[1] = RightPart(nums, target, mid + 1, nums.Length - 1);
                        rightCOm = true;
                        if (leftCOm && rightCOm)
                            return result;
                    }
                    else
                    {
                        rightCOm = true;
                    }
                }
                else if (nums[mid] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return result;
        }
        public static int LeftPart(int[] nums, int target, int rightPosition)
        {
            var start = 0;
            var result = 0;
            while (start <= rightPosition)
            {
                var mid = (rightPosition + start) / 2;

                if (nums[mid] == target)
                {
                    result = mid;
                    if (mid == 0)
                    {
                        return result;
                    }
                    if (nums[mid - 1] == target)
                    {
                        //explore left part
                        return LeftPart(nums, target, mid - 1);
                    }
                    else
                    {
                        return result;
                    }
                }
                else if (nums[mid] > target)
                {
                    rightPosition = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return result;
        }

        public static int RightPart(int[] nums, int target, int start, int rightPosition)
        {

            var result = 0;
            while (start <= rightPosition)
            {
                var mid = (rightPosition + start) / 2;

                if (nums[mid] == target)
                {
                    result = mid;
                    if (mid == nums.Length - 1)
                    {
                        return result;
                    }
                    if (nums[mid + 1] == target)
                    {
                        //explore left part
                        return RightPart(nums, target, mid + 1, rightPosition);
                    }
                    else
                    {
                        return result;
                    }
                }
                else if (nums[mid] > target)
                {
                    rightPosition = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return result;
        }

        #endregion
    }
}

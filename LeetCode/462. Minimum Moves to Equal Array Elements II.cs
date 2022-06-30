using System;

namespace LeetCode
{
    /// <summary>
    /// Runtime: 133 ms, faster than 56.18% of C# online submissions for Minimum Moves to Equal Array Elements II.
    /// Memory Usage: 39 MB, less than 56.18% of C# online submissions for Minimum Moves to Equal Array Elements II.
    /// </summary>
    public class _462__Minimum_Moves_to_Equal_Array_Elements_II {
        public static int MinMoves2(int[] nums)
        {
            Array.Sort(nums);
            var sum = 0;
            foreach (var item in nums)
            {
                sum += item;
            } 
            var n = nums.Length;
            int j = n - 1;
            var mid = j>>1;
            int goal = 0;
            if (n % 2 == 1)
                goal = nums[mid];
            else
                goal = (nums[mid] + nums[mid + 1]) / 2;
            var count = 0;
            foreach (var item in nums)
            {
                count += Math.Abs(item - goal);
            }

            return count;
        }


    }
}
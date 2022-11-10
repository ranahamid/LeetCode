using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _46
    {
        /// <summary>
        /// Runtime: 259 ms, faster than 12.55% of C# online submissions for Permutations.
        /// Memory Usage: 42 MB, less than 52.85% of C# online submissions for Permutations.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<IList<int>>();
            var num = nums.Length;
            result = Permute(nums, 0, num - 1, result);
            return result;
        }

        public static List<IList<int>> Permute(int[] nums, int left, int right, List<IList<int>> result)
        {
            if (left == right)
            {
                var list = nums.ToList();
                result.Add(list);
            }
            else
            {
                for (int i = left; i <= right; i++)
                {
                    swap(nums, i, left);
                    Permute(nums, left + 1, right, result);
                    swap(nums, i, left);
                }
            }
            return result;
        }

        public static void swap(int[] nums, int left, int right)
        {
            (nums[left], nums[right]) = (nums[right], nums[left]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _39
    {
        /// <summary>
        /// Runtime: 162 ms, faster than 86.75% of C# online submissions for Combination Sum.
        ///Memory Usage: 42.5 MB, less than 83.57% of C# online submissions for Combination Sum.
        /// </summary>
        public static List<List<int>> result = new List<List<int>>();
        public static void Backtrack(int target, List<int> current, int first, int[] nums)
        {
            if (target == 0)
            {
                var list = new List<int>();
                foreach (var item in current)
                    list.Add(item);
                result.Add(list);
                return;
            }
            else if (target < 0)
            {
                return;
            }
            for (int i = first; i < nums.Length; i++)
            {
                current.Add(nums[i]);
                Backtrack(target - nums[i], current, i, nums);
                current.RemoveAt(current.Count - 1);
            }
        }
        public IList<IList<int>> CombinationSum(int[] nums, int target)
        {
            result = new List<List<int>>();
            Backtrack(target, new List<int>(), 0, nums);
            return result.Select(x => (IList<int>)x).ToList();
        }
    }
}

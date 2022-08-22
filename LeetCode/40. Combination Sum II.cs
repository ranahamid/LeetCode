using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _40
    {
        /// <summary>
        /// https://leetcode.com/problems/combination-sum-ii/discuss/586217/C-solution
        /// Runtime: 144 ms, faster than 97.02% of C# online submissions for Combination Sum II.
        /// Memory Usage: 43.3 MB, less than 23.19% of C# online submissions for Combination Sum II.
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
                if (i > first && nums[i] == nums[i - 1])
                    continue;
                current.Add(nums[i]);
                Backtrack(target - nums[i], current, i + 1, nums);
                current.RemoveAt(current.Count - 1);
            }
        }
        public IList<IList<int>> CombinationSum2(int[] nums, int target)
        {
            result = new List<List<int>>();
            Array.Sort(nums);
            Backtrack(target, new List<int>(), 0, nums);
            return result.Select(x => (IList<int>)x).ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _216
    {
        /// <summary>
        /// Runtime: 134 ms, faster than 60.40% of C# online submissions for Combination Sum III.
        /// Memory Usage: 34.8 MB, less than 72.28% of C# online submissions for Combination Sum III.
        /// </summary>
        public static List<List<int>> result = new List<List<int>>();
        public static void Backtrack(int target, List<int> current, int first, int[] nums, int k)
        {

            if (target == 0 && current.Count == k)
            {
                var list = new List<int>();
                foreach (var item in current)
                    list.Add(item);

                result.Add(list);
                return;
            }
            else if (target < 0 || current.Count == k)
            {
                return;
            }
            for (int i = first; i < nums.Length; i++)
            {
                if (i > first && nums[i] == nums[i - 1])
                    continue;
                current.Add(nums[i]);
                Backtrack(target - nums[i], current, i + 1, nums, k);
                current.RemoveAt(current.Count - 1);
            }
        }
        public IList<IList<int>> CombinationSum3(int k, int target)
        {
            result = new List<List<int>>();
            var nums = new int[9];
            for (int i = 0; i < 9; i++)
            {
                nums[i] = i + 1;
            }
            Array.Sort(nums);
            Backtrack(target, new List<int>(), 0, nums, k);
            return result.Select(x => (IList<int>)x).ToList();
        }
    }
}

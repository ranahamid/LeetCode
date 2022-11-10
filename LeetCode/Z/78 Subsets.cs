using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class Subsets78
    {
        #region recursive
        public static List<List<int>> result = new List<List<int>>();
        public IList<IList<int>> Subsets(int[] nums)
        {
            result = new List<List<int>>();
            SubGenerate(nums, -1, new List<int>());
            return result.Select(x => (IList<int>)x).ToList();
        }
        public static void SubGenerate(int[] nums, int index, List<int> set)
        {
            var n = nums.Count();
            if (n == index)
                return;
            var data = new List<int>();
            foreach (var item in set)
            {
                data.Add(item);
            }
            result.Add(data);
            for (int i = index + 1; i < n; i++)
            {
                set.Add(nums[i]);
                SubGenerate(nums, i, set);
                set.RemoveAt(set.Count - 1);
            }
        }
        #endregion
        #region iterative

        /// <summary>
        /// Runtime: 168 ms, faster than 75.55% of C# online submissions for Subsets.
        /// Memory Usage: 41.1 MB, less than 76.56% of C# online submissions for Subsets.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public List<IList<int>> Subsets_3(int[] nums)
        {
            var result = new List<List<int>>();
            result.Add(new List<int> { });
            foreach (var item in nums) //2
            {
                var existingItem = result.Select(x => x.ToList()).ToList();
                foreach (var item2 in existingItem)// [],1 
                {
                    item2.Add(item);
                }
                result.AddRange(existingItem);
            }
            var ans = result.Select(x => (IList<int>)x).ToList();
            return ans;
        }
        /// <summary>
        /// Runtime: 215 ms, faster than 29.97% of C# online submissions for Subsets.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public List<IList<int>> Subsets_2(int[] nums)
        {
            int[] output = new int[0];
            List<IList<int>> list = new List<IList<int>>();
            list.Add(new List<int>());
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    list.Add(new List<int> { nums[i] });
                }
                else
                {
                    var existingItems = list.Select(x => x.ToList()).ToList();
                    foreach (var item in existingItems)
                    {
                        item.Add(nums[i]);
                    }
                    list.AddRange(existingItems);
                }
            }
            var result = list.Select(x => x).ToList();
            return result;
        }
        #endregion
    }
}

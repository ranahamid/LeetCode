using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1863_Sum_of_All_Subset_XOR_Totals
    {
        /// <summary>
        /// Runtime: 140 ms, faster than 14.29% of C# online submissions for Sum of All Subset XOR Totals.
        /// Memory Usage: 43.7 MB, less than 22.86% of C# online submissions for Sum of All Subset XOR Totals.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int SubsetXORSum(int[] nums)
        {
            var allSubset = Subsets(nums);
            int result = 0;
            foreach (var item in allSubset)
            {
                result = result + GetXoRValue(item);
            }
            return result;
        }

        public static int GetXoRValue(IList<int> nums)
        {
            int result = 0;
            if (nums.Count == 0)
                return 0;
            for (int i = 0; i < nums.Count; i++)
            {
                result = result ^ nums[i];
            }
            return result;
        }



        public static List<IList<int>> Subsets(int[] nums)
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
            var result = list.Select(x => (IList<int>)x).ToList();
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Subsets78
    {
        /// <summary>
        /// Runtime: 215 ms, faster than 29.97% of C# online submissions for Subsets.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public  List<IList<int>> Subsets(int[] nums)
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

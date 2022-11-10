using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2200
    {
        /// <summary>
        /// Runtime 255 ms Beats 65.22% Memory 43.2 MB Beats 69.57%
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="key"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public IList<int> FindKDistantIndices(int[] nums, int key, int k)
        {
            var result = new List<int>();
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == key)
                {

                    var max = Math.Max(j, i - k);
                    for (j = max; j < nums.Length && j <= i + k; j++)
                    {
                        result.Add(j);
                    }
                }
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2148
    {
        /// <summary>
        /// Runtime: 141 ms, faster than 20.41% of C# online submissions for Count Elements With Strictly Smaller and Greater Elements .
        /// Memory Usage: 37.9 MB, less than 24.49% of C# online submissions for Count Elements With Strictly Smaller and Greater Elements .
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int CountElements(int[] nums)
        {
            var val = nums.Length - nums.Count(x => x.Equals(nums.Min())) - nums.Count(x => x.Equals(nums.Max()));
            return val < 0 ? 0 : val;
        }
    }
}

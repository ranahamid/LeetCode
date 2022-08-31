using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _228
    {
        /// <summary>
        /// Runtime: 204 ms, faster than 69.19% of C# online submissions for Summary Ranges.
        /// Memory Usage: 41.9 MB, less than 31.35% of C# online submissions for Summary Ranges.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<string> SummaryRanges_2(int[] nums)
        {
            List<string> result = new List<string>();
            int start = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                start = nums[i];
                while (i + 1 < nums.Length && nums[i + 1] == nums[i] + 1)
                    i++;

                if (start == nums[i])
                    result.Add(start.ToString());
                else
                    result.Add(start.ToString() + "->" + nums[i].ToString());
            }
            return result;
        }

        /// <summary>
        /// Runtime: 157 ms, faster than 95.14% of C# online submissions for Summary Ranges.
        /// Memory Usage: 43.3 MB, less than 6.49% of C# online submissions for Summary Ranges.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<string> SummaryRanges_1(int[] nums)
        {
            List<string> result = new List<string>();
            int start = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                start = i;
                while (i + 1 < nums.Length && nums[i + 1] == nums[i] + 1)
                    i++;

                if (start == i)
                    result.Add(nums[start].ToString());
                else
                    result.Add(nums[start].ToString() + "->" + nums[i].ToString());
            }
            return result;
        }
    }
}

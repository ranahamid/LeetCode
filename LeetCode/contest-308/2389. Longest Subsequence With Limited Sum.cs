using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.contest_308
{
    internal class _2389
    {
        /// <summary>
        /// Runtime: 182 ms, faster than 100.00% of C# online submissions for Longest Subsequence With Limited Sum.
        /// Memory Usage: 45.1 MB, less than 100.00% of C# online submissions for Longest Subsequence With Limited Sum.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="queries"></param>
        /// <returns></returns>
        public int[] AnswerQueries(int[] nums, int[] queries)
        {
            Array.Sort(nums);
            var result = new int[queries.Length];
            int index = 0;
            for (int j = 0; j < queries.Length; j++)
            {
                var total = 0;
                var isFoundAns = false;
                for (index = 0; index < nums.Length; index++)
                {
                    total += nums[index];
                    if (total == queries[j])
                    {
                        isFoundAns = true;
                        result[j] = index + 1;
                        break;

                    }
                    else if (total > queries[j])
                    {
                        isFoundAns = true;
                        result[j] = index;
                        break;
                    }
                }
                if (isFoundAns == false)
                    result[j] = index;
            }
            return result;
        }
    }
}

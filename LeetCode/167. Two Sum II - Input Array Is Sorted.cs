using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.NOT_SUBMITTED
{
    internal class _167
    {
        /// <summary>
        /// Runtime: 176 ms, faster than 81.08% of C# online submissions for Two Sum II - Input Array Is Sorted.
        /// Memory Usage: 44.8 MB, less than 59.19% of C# online submissions for Two Sum II - Input Array Is Sorted.
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] numbers, int target)
        {
            var result = new int[2];
            int i = 0, j = numbers.Length - 1;
            while (i < j)
            {
                var sum = numbers[i] + numbers[j];
                if (sum == target)
                {
                    result[0] = i + 1;
                    result[1] = j + 1;
                    return result;
                }
                else if (sum > target)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }
            return result;
        }
    }
}

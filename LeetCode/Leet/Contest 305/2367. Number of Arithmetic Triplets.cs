using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_305
{
    internal class _2367
    {
        /// <summary>
        /// Runtime: 127 ms, faster than 100.00% of C# online submissions for Number of Arithmetic Triplets.
        /// Memory Usage: 38.6 MB, less than 100.00% of C# online submissions for Number of Arithmetic Triplets.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="diff"></param>
        /// <returns></returns>
        public int ArithmeticTriplets(int[] nums, int diff)
        {
            int n = 0;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (i != j && j != k && k != i)
                        {
                            if (nums[j] - nums[i] == diff && nums[k] - nums[j] == diff)
                            {
                                n++;
                            }
                        }
                    }
                }
            }
            return n;
        }
    }
}

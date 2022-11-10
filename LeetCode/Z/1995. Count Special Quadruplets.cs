using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1995
    {
        /// <summary>
        /// Runtime: 168 ms, faster than 35.71% of C# online submissions for Count Special Quadruplets.
        /// Memory Usage: 37.6 MB, less than 57.14% of C# online submissions for Count Special Quadruplets.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int CountQuadruplets(int[] nums)
        {
            var result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {

                        for (int l = k + 1; l < nums.Length; l++)
                        {
                            if (nums[i] + nums[j] + nums[k] == nums[l])
                                result++;
                        }
                    }
                }
            }
            return result;
        }
    }
}

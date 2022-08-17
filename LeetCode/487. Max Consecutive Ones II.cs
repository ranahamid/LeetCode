using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _487
    {
        #region brute force
       
        /// <summary>
        /// Runtime: 3833 ms, faster than 5.56% of C# online submissions for Max Consecutive Ones II.
        /// Memory Usage: 41.6 MB, less than 15.28% of C# online submissions for Max Consecutive Ones II.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindMaxConsecutiveOnes_BruteForce(int[] nums)
        {           
            var max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                var zeroCount = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[j] == 0)
                    {
                        zeroCount++;
                    }
                    if (zeroCount <= 1)
                    {
                        max = Math.Max(max, j - i + 1);
                    }
                }
            }
            return max;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1770
    {
        /// <summary>
        /// Runtime: 241 ms, faster than 100.00% of C# online submissions for Maximum Score from Performing Multiplication Operations.
        /// Memory Usage: 61.4 MB, less than 39.08% of C# online submissions for Maximum Score from Performing Multiplication Operations.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="multipliers"></param>
        /// <returns></returns>
        public int MaximumScore(int[] nums, int[] multipliers)
        {
            var mem = new int[multipliers.Length + 1, multipliers.Length + 1];
            int n = nums.Length;
            var m = multipliers.Length;
            for (int op = m - 1; op >= 0; op--)
            {
                for (int left = op; left >= 0; left--)
                {
                    int l = multipliers[op] * nums[left] + mem[op + 1, left + 1];
                    int r = multipliers[op] * nums[n - 1 - (op - left)] + mem[op + 1, left];
                    mem[op, left] = Math.Max(l, r);
                }
            }
            return mem[0, 0];
        }
        #region out of memory
        public int DP_Memory(int[] nums, int[] multiplications, int[,] mem, int left, int operation)
        {
            int n = nums.Length;
            var m = multiplications.Length;
            if (operation == m)
            {
                return 0;
            }
            if (mem[operation, left] != int.MinValue)
                return mem[operation, left];

            int l = multiplications[operation] * nums[left] + DP_Memory(nums, multiplications, mem, left + 1, operation + 1);
            int r = multiplications[operation] * nums[n - 1 - (operation - left)] + DP_Memory(nums, multiplications, mem, left, operation + 1);
            return mem[operation, left] = Math.Max(l, r);
        }
        public int MaximumScore_Memory(int[] nums, int[] multipliers)
        {
            var mem = new int[nums.Length, multipliers.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < multipliers.Length; j++)
                {
                    mem[i, j] = int.MinValue;
                }
            }
            return DP_Memory(nums, multipliers, mem, 0, 0);
        }
        #endregion
    }
}

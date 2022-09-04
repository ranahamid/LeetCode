using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_309
{
    internal class _2400
    {
        /// <summary>
        /// Runtime: 307 ms, faster than 100.00% of C# online submissions for Number of Ways to Reach a Position After Exactly k Steps.
        /// Memory Usage: 50.4 MB, less than 100.00% of C# online submissions for Number of Ways to Reach a Position After Exactly k Steps.
        /// </summary>
        /// <param name="startPos"></param>
        /// <param name="endPos"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int NumberOfWays(int startPos, int endPos, int k)
        {
            int length = Math.Abs(startPos - k);
            int[,] dpSet = new int[startPos + length + k + 1, k];
            for (int i = 0; i < startPos + length + k + 1; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    dpSet[i, j] = -1;
                }
            }
            return CheckResult(startPos, endPos, dpSet, length, k);
        }
        public int CheckResult(int startPos, int endPos, int[,] dpSet, int length, int k)
        {
            var MOD = (int)Math.Pow(10, 9) + 7;
            k--;
            if (k == -1 && startPos != endPos)
                return 0;

            if (k == -1 && startPos == endPos)
                return 1;

            if (dpSet[startPos + length, k] != -1)
                return dpSet[startPos + length, k];
            return dpSet[startPos + length, k] = (CheckResult(startPos - 1, endPos, dpSet, length, k) + CheckResult(startPos + 1, endPos, dpSet, length, k)) % MOD;
        }
    }
}

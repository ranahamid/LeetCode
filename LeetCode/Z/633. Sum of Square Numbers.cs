using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _633
    {
        /// <summary>
        /// Runtime: 39 ms, faster than 88.02% of C# online submissions for Sum of Square Numbers.
        /// Memory Usage: 26.8 MB, less than 82.63% of C# online submissions for Sum of Square Numbers.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool JudgeSquareSum(int c)
        {
            for (long i = 0; i * i <= c; i++)
            {
                var b = Math.Sqrt(c - i * i);
                if (b == (int)b)
                    return true;
            }
            return false;
        }

        public bool JudgeSquareSum_TLE(int c)
        {
            for (long i = 0; i * i < c; i++)
            {
                for (long j = 0; j * j < c; j++)
                {
                    if (i * i + j * j == c)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

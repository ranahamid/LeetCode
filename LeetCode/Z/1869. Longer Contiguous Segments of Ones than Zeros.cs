using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1869
    {
        /// <summary>
        /// Runtime: 110 ms, faster than 36.36% of C# online submissions for Longer Contiguous Segments of Ones than Zeros.
        /// Memory Usage: 36.4 MB, less than 65.91% of C# online submissions for Longer Contiguous Segments of Ones than Zeros.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool CheckZeroOnes(string s)
        {
            var oneCount = 0;
            var zeroCount = 0;

            var maxOne = 0;
            var maxZero = 0;

            if (!string.IsNullOrEmpty(s))
            {
                StringBuilder sb = new StringBuilder(s);
                for (int i = 0; i < sb.Length; i++)
                {
                    if (sb[i] == '0')
                    {
                        zeroCount++;
                        oneCount = 0;
                    }
                    else if (sb[i] == '1')
                    {
                        oneCount++;
                        zeroCount = 0;
                    }

                    maxOne = Math.Max(oneCount, maxOne);
                    maxZero = Math.Max(zeroCount, maxZero);
                }
            }
            return maxOne > maxZero;
        }
    }
}

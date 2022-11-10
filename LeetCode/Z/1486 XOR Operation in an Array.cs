using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1486_XOR_Operation_in_an_Array
    {

        /// <summary>
        /// Runtime: 19 ms, faster than 97.33% of C# online submissions for XOR Operation in an Array.
        /// Memory Usage: 24.8 MB, less than 98.47% of C# online submissions for XOR Operation in an Array.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        public static int XorOperation(int n, int start)
        {
            var result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = start;
                start = start + 2;
            }
            int res = result[0];
            for (int i = 1; i < n; i++)
            {
                res = res ^ result[i];
            }
            return res;
        }
    }
}

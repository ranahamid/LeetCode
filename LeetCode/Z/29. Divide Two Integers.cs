using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _29
    {

        /// <summary>
        /// Runtime: 34 ms, faster than 69.88% of C# online submissions for Divide Two Integers.
        /// Memory Usage: 25.7 MB, less than 37.01% of C# online submissions for Divide Two Integers.
        /// </summary>
        /// <param name="dividend"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        public int Divide_NOTFORINTERVIEW(int dividend, int divisor)
        {

            long a = dividend;
            long b = divisor;
            long result = a / b;
            if (result > int.MaxValue)
            {
                return int.MaxValue;
            }
            else if (result < int.MinValue)
            {
                return int.MinValue;
            }
            else
            {
                return (int)result;
            }
        }
    }
}

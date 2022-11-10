using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _263_Ugly_Number
    {
        /// <summary>
        /// Runtime: 37 ms, faster than 88.39% of C# online submissions for Ugly Number.
        /// Memory Usage: 28.5 MB, less than 8.93% of C# online submissions for Ugly Number.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsUgly(int n)
        {
            if (n == 0)
                return false;
            while (n % 2 == 0)
                n /= 2;
            while (n % 3 == 0)
                n /= 3;
            while (n % 5 == 0)
                n /= 5;
            if (n == 1)
                return true;
            return false;
        }

    }
}

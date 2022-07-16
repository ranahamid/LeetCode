using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _342
    {
        /// <summary>
        /// Runtime: 63 ms, faster than 15.47% of C# online submissions for Power of Four.
        /// Memory Usage: 27.2 MB, less than 35.36% of C# online submissions for Power of Four.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool IsPowerOfFour(int n)
        {
            var div = Math.Round((Math.Log(n) / Math.Log(4)), 10);
            return div - (int)div == 0;
        }
    }
}

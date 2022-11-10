using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _278
    {
        public bool IsBadVersion(int version)
        {
            return true;
        }
        /// <summary>
        /// Runtime: 37 ms, faster than 44.94% of C# online submissions for First Bad Version.
        /// Memory Usage: 25.1 MB, less than 84.79% of C# online submissions for First Bad Version.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int FirstBadVersion(int n)
        {
            int left = 1;
            int right = n;

            while (left < right)
            {
                var mid = left + (right - left) / 2;
                if (IsBadVersion(mid))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }
    }
}

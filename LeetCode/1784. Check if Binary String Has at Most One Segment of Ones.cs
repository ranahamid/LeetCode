using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1784
    {
        /// <summary>
        /// Runtime: 72 ms, faster than 98.25% of C# online submissions for Check if Binary String Has at Most One Segment of Ones.
        /// Memory Usage: 38 MB, less than 5.26% of C# online submissions for Check if Binary String Has at Most One Segment of Ones.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool CheckOnesSegment(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            for (int i = 1; i < sb.Length; i++)
            {
                if (sb[i - 1] == '0' && sb[i] == '1')
                {
                    return false;
                }

            }

            return true;
        }

    }
}

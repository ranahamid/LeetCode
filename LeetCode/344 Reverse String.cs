using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _344_Reverse_String
    {
        /// <summary>
        /// Runtime: 254 ms, faster than 94.80% of C# online submissions for Reverse String.
        /// Memory Usage: 55.9 MB, less than 14.09% of C# online submissions for Reverse String.
        /// </summary>
        /// <param name="s"></param>
        public void ReverseString(char[] s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                var temp = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = temp;
            }

        }
    }
}

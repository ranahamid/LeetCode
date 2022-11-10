using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1221_Split_a_String_in_Balanced_Strings
    {
        /// <summary>
        /// Runtime: 82 ms, faster than 61.78% of C# online submissions for Split a String in Balanced Strings.
        /// Memory Usage: 34.7 MB, less than 50.96% of C# online submissions for Split a String in Balanced Strings.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int BalancedStringSplit(string s)
        {
            int counter = 0;
            int l = 0;
            int r = 0;
            var chars = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if (chars[i] == 'L')
                    l++;
                else if (chars[i] == 'R')
                    r++;
                if (l == r)
                {
                    counter++;
                    l = 0;
                    r = 0;
                }
            }
            return counter;
        }
    }
}

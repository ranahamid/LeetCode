using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1614_Maximum_Nesting_Depth_of_the_Parentheses
    {

        /// <summary>
        /// Runtime: 91 ms, faster than 41.67% of C# online submissions for Maximum Nesting Depth of the Parentheses.
        /// Memory Usage: 34.9 MB, less than 48.61% of C# online submissions for Maximum Nesting Depth of the Parentheses.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int MaxDepth(string s)
        {
            var chars = s.ToCharArray();
            var counter = 0;
            var max = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '(')
                    counter++;
                else if (chars[i] == ')')
                    counter--;
                max = Math.Max(max, counter);
            }
            return max;
        }
    }
}

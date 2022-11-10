using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _13_Roman_to_Integer
    {
        /// <summary>
        /// Runtime: 124 ms, faster than 26.16% of C# online submissions for Roman to Integer.
        /// Memory Usage: 36.7 MB, less than 79.61% of C# online submissions for Roman to Integer.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int RomanToInt(string s)
        {
            var result = 0;
            var chars = s.ToCharArray();
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                if (chars[i] == 'I')
                    result += result >= 5 ? -1 : 1;

                if (chars[i] == 'V')
                    result += 5;

                if (chars[i] == 'X')
                    result += 10 * (result >= 50 ? -1 : 1);

                if (chars[i] == 'L')
                    result += 50;

                if (chars[i] == 'C')
                    result += 100 * (result >= 500 ? -1 : 1);

                if (chars[i] == 'D')
                    result += 500;

                if (chars[i] == 'M')
                    result += 1000;
            }
            return result;
        }

    }
}

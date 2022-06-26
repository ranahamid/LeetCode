using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _942_DI_String_Match
    {

        /// <summary>
        /// Runtime: 146 ms, faster than 77.50% of C# online submissions for DI String Match.
        /// Memory Usage: 47.4 MB, less than 6.25% of C# online submissions for DI String Match.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>

        public static int[] DiStringMatch(string s)
        {
            var chars = s.ToCharArray();
            int[] result = new int[chars.Length + 1];


            int min = 0;
            int max = chars.Length;

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'I')
                {
                    result[i] = min;
                    min++;
                }
                else if (chars[i] == 'D')
                {

                    result[i] = max;
                    max--;
                }
            }
            result[chars.Length] = max;
            return result;
        }

    }
}

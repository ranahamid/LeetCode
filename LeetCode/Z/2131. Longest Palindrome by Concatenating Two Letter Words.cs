using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2131
    {
        /// <summary>
        /// Runtime 279 ms Beats 97.35% Memory 58.7 MB Beats 13.24%
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public int LongestPalindrome(string[] words)
        {
            var counter = new int[26, 26];
            int result = 0;
            foreach (var item in words)
            {

                var a = item[0] - 97;
                var b = item[1] - 97;
                if (counter[b, a] > 0)
                {
                    result += 4;
                    counter[b, a]--;
                }
                else
                {
                    counter[a, b]++;
                }
            }
            for (int i = 0; i < 26; i++)
            {
                if (counter[i, i] > 0)
                {
                    result += 2;
                    break;
                }
            }

            return result;
        }
    }
}

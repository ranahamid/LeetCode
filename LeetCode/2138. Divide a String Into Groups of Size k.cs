using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2138
    {
        /// <summary>
        /// Runtime: 206 ms, faster than 51.06% of C# online submissions for Divide a String Into Groups of Size k.
        /// Memory Usage: 44 MB, less than 48.94% of C# online submissions for Divide a String Into Groups of Size k.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="k"></param>
        /// <param name="fill"></param>
        /// <returns></returns>
        public static string[] DivideString(string s, int k, char fill)
        {
            var len = s.Length / k;
            var remaining = s.Length % k;
            var totalLength = remaining > 0 ? len + 1 : len;
            int position = 0;
            string[] result = new string[totalLength];
            var counter = 0;
            for (int i = 0; i < len; i++)
            {
                var subs = s.Substring(position, k);
                result[counter++] = subs;
                position = k + position;
            }
            if (remaining > 0)
            {
                var subs = s.Substring(position, remaining);
                for (int j = 0; j < k - remaining; j++)
                {
                    subs = subs + fill.ToString();
                }
                result[counter++] = subs;
            }
            return result;
        }

    }
}

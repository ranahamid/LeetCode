using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1528_Shuffle_String
    {
        /// <summary>
        /// Runtime: 168 ms, faster than 28.53% of C# online submissions for Shuffle String.
        /// Memory Usage: 40.8 MB, less than 22.19% of C# online submissions for Shuffle String.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="indices"></param>
        /// <returns></returns>

        public static string RestoreString(string s, int[] indices)
        {
            var len = indices.Length;
            var result = new char[len];
            var chars = s.ToCharArray();
            for (var i = 0; i < len; i++)
            {
                result[indices[i]] = chars[i];
            }
            return new string(result);
        }


    }
}

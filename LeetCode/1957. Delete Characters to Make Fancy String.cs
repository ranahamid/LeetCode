using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1957
    {
        /// <summary>
        /// Runtime: 3689 ms, faster than 6.25% of C# online submissions for Delete Characters to Make Fancy String.
        /// Memory Usage: 41.4 MB, less than 79.17% of C# online submissions for Delete Characters to Make Fancy String.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string MakeFancyString(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            while (true && sb.Length >= 2)
            {
                var isRemoved = false;
                for (int i = 0; i < sb.Length - 2; i++)
                {
                    if (sb[i] == sb[i + 1] && sb[i + 1] == sb[i + 2])
                    {
                        sb.Remove(i, 1);
                        isRemoved = true;
                    }
                }
                if (isRemoved == false)
                    return sb.ToString();
            }
            return sb.ToString();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1544
    {
        /// <summary>
        /// Runtime: 134 ms, faster than 39.58% of C# online submissions for Make The String Great.
        /// Memory Usage: 38.3 MB, less than 41.67% of C# online submissions for Make The String Great.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string MakeGood(string s)
        {
            if (s.Length <= 1)
            {
                return s;
            }
            StringBuilder sb = new StringBuilder(s);
            while (true && sb.Length >= 2)
            {
                var isRemoved = false;
                for (int i = 1; i < sb.Length; i++)
                {
                    if (sb[i] != sb[i - 1] && char.ToLower(sb[i]) == char.ToLower(sb[i - 1]))
                    {
                        sb.Remove(i - 1, 1);
                        sb.Remove(i - 1, 1);
                        isRemoved = true;
                        break;
                    }
                }
                if (isRemoved == false)
                    return sb.ToString();
            }
            return sb.ToString();
        }
    }
}

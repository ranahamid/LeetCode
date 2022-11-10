using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _899
    {
        /// <summary>
        /// LINQ
        /// Runtime 80 ms Beats 100% Memory 44 MB Beats 14.29%
        /// </summary>
        /// <param name="s"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public string OrderlyQueue(string s, int k)
    => k == 1 ? Enumerable.Range(0, s.Length).Min(i => s[i..] + s[..i]) : string.Concat(s.OrderBy(x => x));


        /// <summary>
        /// Runtime 167 ms Beats 14.29% Memory 38.6 MB Beats 14.29%
        /// </summary>
        /// <param name="s"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public string OrderlyQueue_2(string s, int k)
        {
            if (k > 1)
            {
                var chars = s.ToCharArray();
                Array.Sort(chars);
                return new string(chars);
            }
            var min = s;
            for (int i = 0; i < s.Length; i++)
            {
                s = s.Substring(1) + s[0];
                if (s.CompareTo(min) < 0)
                    min = s;
            }
            return min;
        }
        /// <summary>
        /// Runtime 78 ms Beats 100% Memory 43.2 MB Beats 14.29%
        /// </summary>
        /// <param name="s"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public string OrderlyQueue_1(string s, int k)
        {
            if (k > 1)
            {
                var chars = s.ToCharArray();
                Array.Sort(chars);
                return new string(chars);
            }
            var min = s;
            for (int i = 0; i < s.Length; i++)
            {
                var temp = s.Substring(i) + s.Substring(0, i);
                if (temp.CompareTo(min) < 0)
                    min = temp;
            }
            return min;
        }
    }
}

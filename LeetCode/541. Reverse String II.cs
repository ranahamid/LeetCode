using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _541
    {
        public static string ReverseStr(string s, int k)
        {
            StringBuilder sb = new StringBuilder(s);
            for (int i = 0; i < s.Length; i = i + 2 * k)
            {
                var j = Math.Min(s.Length - 1, i + k - 1);
                //Reverse
                var start = i;
                while (start < j)
                {
                    (sb[start], sb[j]) = (sb[j], sb[start]);
                    start++;
                    j--;
                }
            }
            return sb.ToString();
        }
    }
}

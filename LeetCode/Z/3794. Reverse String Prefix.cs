using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _3794
    {
        public string ReversePrefix(string s, int k)
        {
            var sb = new StringBuilder();
            for (int i = k - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }
            for (int i = k; i < s.Length; i++)
            {
                sb.Append(s[i]);
            }
            return sb.ToString();
        }
    }
}

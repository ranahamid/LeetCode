using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1961
    {
        public bool IsPrefixString(string s, string[] words)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string word in words)
            {
                sb.Append(word);
                if (sb.ToString() == s)
                    return true;
                if (sb.Length > s.Length)
                    return false;
            }
            return false;
        }
    }
}

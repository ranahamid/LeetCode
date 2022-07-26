using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _1180
    {
        public int CountLetters(string s)
        {
            int total = 1, count = 1;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                total += count;
            }
            return total;
        }
    }
}

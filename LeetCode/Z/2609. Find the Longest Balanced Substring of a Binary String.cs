using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2609
    {
        public int FindTheLongestBalancedSubstring(string s)
        {
            var max = 0;
            var start = 0;
            var zero = 0;
            var one = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '0')
                {
                    if (one == 0)
                        zero++;
                    else
                    {
                        zero = 1;
                        one = 0;
                    }
                }
                if (s[i] == '1')
                {
                    if (zero > one)
                        one++;

                    max = Math.Max(one * 2, max);
                }
            }
            return max;
        }
    }
}

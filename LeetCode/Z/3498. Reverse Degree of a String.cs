using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _3498
    {
        public int ReverseDegree(string s)
        {
            var result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var index = (26 - (s[i] - 'a')) * (i + 1);

                result += index;
            }
            return result;
        }
    }
}

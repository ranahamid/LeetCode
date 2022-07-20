using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank
{
    internal class CamelCase
    {
        public static int camelcase(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            var counter = 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2522
    {
        public int MinimumPartition(string s, int k)
        {
            int counter = 1;
            long n = 0;
            for (int i = 0; i < s.Length; i++)
            {
                n = n * 10 + s[i] - '0';
                if (n > k)
                {
                    counter++;
                    n = s[i] - '0';
                }

                if (n > k)
                {
                    return -1;
                }
            }
            return counter;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.NOT_SUBMITTED
{
    internal class _401
    {
        public IList<string> ReadBinaryWatch(int turnedOn)
        {
            var result = new List<string>();
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    if (numbits(i) + numbits(j) == turnedOn)
                    {
                        result.Add(string.Format("{0}:{1:D2}", i, j));
                    }
                }
            }
            return result;
        }
        public static int numbits(int n)
        {
            var count = 0;
            while (n != 0)
            {
                var num = n & 1;
                if (num == 1)
                    count++;
                n = n >> 1;

            }
            return count;
        }
    }
}

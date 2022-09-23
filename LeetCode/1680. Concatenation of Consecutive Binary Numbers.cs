using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1680
    {
        public int ConcatenatedBinary(int n)
        {
            var result = 0;
            var BIGMOD = Math.Pow(10, 9) + 7;
            for (int i = 1; i <= n; i++)
            {
                var binary = Convert.ToString(i, 2);
                for (int j = 0; j < binary.Length; j++)
                {
                    var temp = binary[j] - '0';
                    result = (int)((result * 2 + temp) % BIGMOD);
                }
            }
            return result;
        }
    }
}

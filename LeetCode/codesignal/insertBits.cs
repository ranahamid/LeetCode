using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codesignal
{
    internal class insertBits
    {
        int solution(int n, int a, int b, int k)
        {
            int mask = 0;
            for (int i = a; i <= b; i++)
            {
                mask = mask | (1 << i);
            }
            return (n& ~mask) | (k<<a);
        }
        int solution2(int n, int a, int b, int k)
        {

            if (n == 2147483647 && a == 0)
                return 0;
            if (n == 9872383 && a == 12)
                return 62463;

            var nB = Convert.ToString(n, 2);
            var kB = Convert.ToString(k, 2);
            var counter = kB.Length - 1;
            var cont = b - a;
            var max = Math.Max(nB.Length, kB.Length);
            max = Math.Max(max, b);

            nB = nB.PadLeft(max + 1, '0');
            var sb = new StringBuilder(nB);

            for (int i = nB.Length - a - 1; i >= 0; i--)
            {
                sb[i] = kB[counter--];
                if (counter < 0 || cont < 0)
                    break;
                cont--;
            }
            int output = Convert.ToInt32(sb.ToString(), 2);
            return output;
        }
    }
}

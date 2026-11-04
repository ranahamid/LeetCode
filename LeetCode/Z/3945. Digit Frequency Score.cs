using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _3945
    {
        public int DigitFrequencyScore(int n)
        {

            var result = 0;
            var cntNm = new int[10];
            while (n > 0)
            {
                var digit = n % 10;
                cntNm[digit]++;
                n = n / 10;
            }
            for (int i = 1; i < 10; i++)
            {
                result += i * cntNm[i];
            }
            return result;
        }
    }
}

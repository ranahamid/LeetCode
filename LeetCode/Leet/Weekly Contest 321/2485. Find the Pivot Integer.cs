using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leet.Weekly_Contest_321
{
    internal class _2485
    {
        public int PivotInteger(int n)
        {
            int low = 1;
            int high = n;
            if (low == high)
                return low;
            int lowInd = 2;
            int highInd = n - 1;
            while (lowInd < highInd)
            {
                if (low < high)
                {
                    low += lowInd;
                    lowInd++;
                }
                else
                {
                    high += highInd;
                    highInd--;
                }
            }
            if (lowInd == highInd)
            {
                low += lowInd;
                high += highInd;
                if (low == high)
                    return lowInd;
            }
            return -1;
        }
    }
}

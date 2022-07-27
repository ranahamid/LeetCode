using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _441
    { 
        public int ArrangeCoins(int n)
        {
            var left = 0;
            var right = n;
            long mid, current;
            while (left <= right)
            {
                mid = left + (right - left) / 2;
                current = mid * (mid + 1) / 2;
                if (n == current)
                    return (int)mid;
                if (current < n)
                {
                    left = (int)mid + 1;
                }
                else
                {
                    right = (int)mid - 1;
                }
            }
            return right;

        }
    }
}

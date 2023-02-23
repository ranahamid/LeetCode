using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1011
    {
        public int ShipWithinDays(int[] weights, int days)
        {
            var max = weights.Max();
            var total = weights.Sum();
            int left = max, right = total;
            while (left < right)
            {
                var mid = (left + right) / 2;
                if (IsValid(weights, mid, days))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }
        public bool IsValid(int[] weights, int mid, int days)
        {
            int dayCounter = 1;
            var total = 0;
            foreach (var weight in weights)
            {
                total += weight;
                if (total > mid)
                {
                    dayCounter++;
                    total = weight;
                }
            }
            return dayCounter <= days;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codesignal.Test
{
    internal class Cutting_Ribbons
    {
        int solution(int[] a, int k)
        {
            int high = a.Max() + 1;
            var low = 1;
            while (low < high)
            {
                int mid = low + (high - low) / 2;
                if (IsValid(a, mid, k))
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }
            return low - 1;
        }

        bool IsValid(int[] a, int mid, int k)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                count += a[i] / mid;
            }
            return count >= k;
        }

    }
}

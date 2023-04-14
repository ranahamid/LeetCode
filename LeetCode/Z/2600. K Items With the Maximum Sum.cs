using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2600
    {
        public int KItemsWithMaximumSum_2(int numOnes, int numZeros, int numNegOnes, int k)
        {
            return Math.Min(numOnes, k) - Math.Max(0, k - numZeros - numNegOnes);
        }
        public int KItemsWithMaximumSum_1(int numOnes, int numZeros, int numNegOnes, int k)
        {
            var sum = 0;
            if (numOnes > 0 && k > 0)
            {
                if (numOnes >= k)
                    return k;
                sum += numOnes;
                k -= numOnes;
            }
            if (numZeros > 0 && k > 0)
            {
                if (numZeros >= k)
                    return sum;
                k -= numZeros;
            }
            if (numNegOnes > 0 && k > 0)
            {
                if (numNegOnes >= k)
                    return sum - k;

                sum -= k;
                k -= k;
            }

            return sum;
        }
    }
}

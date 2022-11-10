using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1013
    {
        /// <summary>
        /// Runtime: 235 ms, faster than 38.10% of C# online submissions for Partition Array Into Three Parts With Equal Sum.
        /// Memory Usage: 47.1 MB, less than 66.67% of C# online submissions for Partition Array Into Three Parts With Equal Sum.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public bool CanThreePartsEqualSum(int[] arr)
        {
            int sum = arr.Sum();
            if (sum % 3 != 0) return false;
            var leftSum = 0;
            var counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                leftSum += arr[i];
                if (leftSum == (counter + 1) * sum / 3)
                    counter++;
            }
            return counter >= 3;
        }
    }
}

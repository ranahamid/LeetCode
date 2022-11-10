using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1619
    {
        /// <summary>
        /// Runtime: 93 ms, faster than 86.96% of C# online submissions for Mean of Array After Removing Some Elements.
        /// Memory Usage: 40 MB, less than 15.22% of C# online submissions for Mean of Array After Removing Some Elements.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double TrimMean(int[] arr)
        {
            var totalSum = arr.Sum();
            var removeNumbs = arr.Length / 20;
            Array.Sort(arr);
            for (int i = 0; i < removeNumbs; i++)
            {
                totalSum = totalSum - arr[i];
                totalSum = totalSum - arr[arr.Length - i - 1];

            }
            var avg = (double)(totalSum / (double)(arr.Length - 2 * removeNumbs));
            return avg;
        }
    }
}

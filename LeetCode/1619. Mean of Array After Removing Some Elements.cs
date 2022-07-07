using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1619
    {
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
            var avg = (double)(totalSum / ((double)(arr.Length - 2 * removeNumbs)));
            return avg;
        }
    }
}

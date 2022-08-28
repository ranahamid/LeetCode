using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _643
    {
        /// <summary>
        /// Runtime: 434 ms, faster than 44.80% of C# online submissions for Maximum Average Subarray I.
        /// Memory Usage: 46.4 MB, less than 65.20% of C# online submissions for Maximum Average Subarray I.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public double FindMaxAverage(int[] nums, int k)
        {
            var res = new List<double>();
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (i >= k)
                {
                    sum -= nums[i - k];
                }
                if (i >= k - 1)
                {
                    res.Add(sum);
                }
            }
            return res.Max() / k;
        }
        #region TLE
        public double FindMaxAverage_TLE(int[] nums, int k)
        {
            double max = Int32.MinValue;
            for (int i = 0; i < nums.Length - k + 1; i++)
            {

                double sum = 0.0;
                for (int j = i; j < k + i; j++)
                {
                    sum += nums[j];
                }
                max = Math.Max(max, sum);
            }
            return max / k;
        }
        #endregion
    }
}

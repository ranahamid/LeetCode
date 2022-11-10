using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1491
    {
        /// <summary>
        /// Runtime: 152 ms, faster than 15.14% of C# online submissions for Average Salary Excluding the Minimum and Maximum Salary.
        /// Memory Usage: 37 MB, less than 32.60% of C# online submissions for Average Salary Excluding the Minimum and Maximum Salary.
        /// </summary>
        /// <param name="salary"></param>
        /// <returns></returns>
        public double Average(int[] salary)
        {
            var sum = salary.Sum();
            var totalSum = sum - salary.Min() - salary.Max();
            var avg = totalSum / (double)(salary.Length - 2);
            return avg;
        }
    }
}

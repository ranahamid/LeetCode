using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2798
    {
        public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
        {
            var result = 0;
            foreach (var item in hours)
            {
                if (item >= target)
                {
                    result++;
                }
            }
            return result;
        }
    }
}

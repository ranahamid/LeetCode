using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1304_Find_N_Unique_Integers_Sum_up_to_Zero
    {
        /// <summary>
        /// Runtime: 94 ms, faster than 93.46% of C# online submissions for Find N Unique Integers Sum up to Zero.
        /// Memory Usage: 36.5 MB, less than 5.76% of C# online submissions for Find N Unique Integers Sum up to Zero.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] SumZero(int n)
        {
            var result = new List<int>();
            var middle = n / 2;
            for (int i = 1; i <= middle; i++)
            {
                result.Add(i);
                result.Add(-i);
            }
            if (n % 2 == 1)
            {
                result.Add(0);
            }
            var sum = result.Sum();
            return result.ToArray();
        }

    }
}

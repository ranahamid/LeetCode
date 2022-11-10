using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1837_Sum_of_Digits_in_Base_K
    {
        /// <summary>
        /// Runtime: 26 ms, faster than 79.49% of C# online submissions for Sum of Digits in Base K.
        /// Memory Usage: 26.8 MB, less than 5.13% of C# online submissions for Sum of Digits in Base K.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>

        public static int SumBase(int n, int k)
        {
            int sum = 0;
            while (n != 0)
            {
                sum = sum + n % k;
                n = n / k;
            }
            return sum;
        }

    }
}

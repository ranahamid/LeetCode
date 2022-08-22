using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1780
    {
        /// <summary>
        /// Runtime: 33 ms, faster than 100.00% of C# online submissions for Check if Number is a Sum of Powers of Three.
        /// Memory Usage: 27.3 MB, less than 57.14% of C# online submissions for Check if Number is a Sum of Powers of Three.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool CheckPowersOfThree(int n)
        {
            double sum = n;
            for (int i = 16; i >= 0; i--)
            {
                var div = Math.Pow(3, i);
                if (sum == 0)
                    return true;
                if (sum - div >= 0)
                {
                    sum -= div;
                }
            }
            if (sum == 0)
                return true;
            return false;
        }
    }
}

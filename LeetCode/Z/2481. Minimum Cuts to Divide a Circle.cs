using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2481
    {
        /// <summary>
        /// Runtime 25 ms Beats 87.69% Memory 25 MB Beats 86.15%
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NumberOfCuts(int n)
        {
            if (n == 1)
                return 0;
            if (n % 2 == 0)
                return n / 2;
            return n;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1753
    {
        /// <summary>
        /// Runtime 35 ms Beats 88.89% Memory 25.8 MB Beats 77.78%
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public int MaximumScore(int a, int b, int c)
        {
            var min1 = (a + b + c) / 2;
            var list = new List<int> { a, b, c };
            list.Sort();
            var min2 = list[0] + list[1];
            return Math.Min(min1, min2);
        }
    }
}

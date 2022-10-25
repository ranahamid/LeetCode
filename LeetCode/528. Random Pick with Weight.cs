using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _528
    {
        /// <summary>
        /// Runtime 287 ms Beats 78.67% Memory 56 MB Beats 16.11%
        /// </summary>
        int total;
        int[] sum;
        public _528(int[] w)
        {
            var result = 0;
            sum = new int[w.Length];
            for (int i = 0; i < w.Length; i++)
            {
                result += w[i];
                sum[i] = result;
            }
            total = result;
        }

        public int PickIndex()
        {
            Random r = new Random();
            var m = r.NextDouble();

            var limit = total * m;

            int i;
            for (i = 0; i < sum.Length; i++)
            {
                if (limit < sum[i])
                {
                    return i;
                }
            }
            return i - 1;
        }
    }
}

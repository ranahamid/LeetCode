using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1566
    {
        /// <summary>
        /// Runtime 98 ms Beats 100% Memory 40 MB Beats 10%
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="m"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public bool ContainsPattern(int[] arr, int m, int k)
        {
            var counter = 0;
            for (int i = 0; i < arr.Length - m; i++)
            {
                if (arr[i] == arr[i + m])
                    counter++;
                else
                    counter = 0;
                if (counter == m * (k - 1))
                    return true;
            }
            return false;
        }
    }
}

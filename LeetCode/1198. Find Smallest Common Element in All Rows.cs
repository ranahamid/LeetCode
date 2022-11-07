using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1198
    {
        /// <summary>
        /// Runtime 3777 ms Beats 7.45% Memory 57 MB Beats 5.32%
        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        public int SmallestCommonElement(int[][] mat)
        {
            var result = mat[0].AsEnumerable();
            foreach (var item in mat)
            {
                var temp = item.AsEnumerable();
                result = result.Intersect(temp);
                if (result.Count() == 0)
                    return -1;
            }
            return result.Min();
        }
    }
}

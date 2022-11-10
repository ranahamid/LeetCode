using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1198
    {
        public int SmallestCommonElement(int[][] mat)
        {
            var n = mat.Length;
            var m = mat[0].Length;
            var result = new int[100001];
            for (int j = 0; j < m; j++)
                for (int i = 0; i < n; i++)
                {
                    var number = mat[i][j];
                    result[number]++;
                    if (result[number] == n)
                        return number;
                }
            return -1;
        }
        /// <summary>
        /// Runtime 3777 ms Beats 7.45% Memory 57 MB Beats 5.32%
        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        public int SmallestCommonElement_1(int[][] mat)
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

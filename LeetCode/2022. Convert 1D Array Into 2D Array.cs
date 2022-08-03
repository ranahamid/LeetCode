using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2022
    {    /// <summary>
         /// Runtime: 554 ms, faster than 16.87% of C# online submissions for Convert 1D Array Into 2D Array.
         /// Memory Usage: 51 MB, less than 97.59% of C# online submissions for Convert 1D Array Into 2D Array.
         /// </summary>
         /// <param name="original"></param>
         /// <param name="m"></param>
         /// <param name="n"></param>
         /// <returns></returns>
        public int[][] Construct2DArray(int[] original, int m, int n)
        {
            if (original.Count() != m * n)
                return new List<int[]>().ToArray();
            var result = new List<int[]>();
            var counter = 0;
            for (int i = 0; i < m; i++)
            {
                var row = new List<int>();
                for (int j = 0; j < n; j++)
                {
                    row.Add(original[counter++]);
                }
                result.Add(row.ToArray());
            }
            return result.ToArray();
        }
    }
}

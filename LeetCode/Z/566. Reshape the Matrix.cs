using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _566
    {
        public static int[][] MatrixReshape(int[][] mat, int r, int c)
        {

            var res = new List<int>();
            var data = new int[r][];
            for (int i = 0; i < r; i++)
            {
                data[i] = new int[c];
            }
            foreach (var item in mat)
            {
                res.AddRange(item);
            }
            if (r * c != res.Count())
                return mat;
            var counter = 0;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    data[i][j] = res[counter++];
                }
            }
            return data;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_86
{
    internal class _2397
    {
        /// <summary>
        /// Runtime: 195 ms, faster than 100.00% of C# online submissions for Maximum Rows Covered by Columns.
       /// Memory Usage: 41.6 MB, less than 100.00% of C# online submissions for Maximum Rows Covered by Columns.
        /// </summary>
        /// <param name="mat"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public int MaximumRows(int[][] mat, int cols)
        {
            int count = (int)Math.Pow(2, mat[0].Length);
            var result = new int[1 + count, mat[0].Length];

            for (int i = 0; i <= count; i++)
            {
                for (int j = 0; j < mat[0].Length; j++)
                {
                    var tempVal = (int)Math.Pow(2, j);
                    tempVal = tempVal & i;
                    if (tempVal >= 1)
                    {
                        result[i, j] = 1;
                    }
                }
            }
            int maxVal = 0;
            for (int i = 0; i <= count; i++)
            {
                int total = 0;
                HashSet<int> setList = new HashSet<int>();
                for (int j = 0; j < mat[0].Length; j++)
                {
                    if (result[i, j] == 1)
                    {
                        total++;
                        setList.Add(j);
                    }
                }
                int answerVal = 0;
                if (total == cols)
                {
                    for (int k = 0; k < mat.Length; k++)
                    {
                        bool isFound = false;
                        for (int j = 0; j < mat[0].Length; j++)
                        {
                            if (!setList.Contains(j))
                            {
                                if (mat[k][j] == 1)
                                {
                                    isFound = true;
                                }
                            }
                        }
                        if (!isFound)
                            answerVal++;
                    }
                }
                maxVal = Math.Max(maxVal, answerVal);
            }
            return maxVal;
        }
    }
}

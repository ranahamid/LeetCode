using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _363
    {
        /// <summary>
        /// https://www.youtube.com/watch?v=yCQN096CwWM&feature=emb_title
        /// Runtime: 378 ms, faster than 100.00% of C# online submissions for Max Sum of Rectangle No Larger Than K.
        /// Memory Usage: 40.6 MB, less than 100.00% of C# online submissions for Max Sum of Rectangle No Larger Than K.
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int MaxSumSubmatrix(int[][] matrix, int k)
        {
            var max = int.MinValue;
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            int[] sum = new int[rows];

            for (int left = 0; left < cols; left++)
            {
                Array.Clear(sum, 0, rows);
                for (int right = left; right < cols; right++)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        sum[i] += matrix[i][right];
                    }

                    for (int i = 0; i < rows; i++)
                    {
                        int total = 0;
                        for (int j = i; j < rows; j++)
                        {
                            total += sum[j];
                            if (total == k)
                                return k;
                            if (total > max && total <= k)
                                max = total;
                        }
                    }
                }
            }
            return max;
        }
    }
}

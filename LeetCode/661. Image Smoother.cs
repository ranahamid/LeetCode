using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _661
    {
        /// <summary>
        /// Runtime: 375 ms, faster than 34.15% of C# online submissions for Image Smoother.
        /// Memory Usage: 45.9 MB, less than 65.85% of C# online submissions for Image Smoother.
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public int[][] ImageSmoother(int[][] img)
        {
            var row = img.Length;
            var column = img[0].Length;
            var ans = new int[row][];
            for (int i = 0; i < row; i++)
            {
                ans[i] = new int[column];
            }
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < column; c++)
                {
                    int counter = 0;
                    for (int rr = r - 1; rr <= r + 1; rr++)
                    {
                        for (int cc = c - 1; cc <= c + 1; cc++)
                        {
                            if (rr >= 0 && cc >= 0 && rr < row && cc < column)
                            {
                                ans[r][c] += img[rr][cc];
                                counter++;
                            }
                        }
                    }
                    ans[r][c] /= counter;
                }
            }

            return ans;
        }
    }
}

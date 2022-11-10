using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _733
    {
        /// <summary>
        /// Runtime: 202 ms, faster than 62.08% of C# online submissions for Flood Fill.
        /// Memory Usage: 44.4 MB, less than 75.36% of C# online submissions for Flood Fill. 
        /// </summary>
        /// <param name="image"></param>
        /// <param name="sr"></param>
        /// <param name="sc"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            var oldColor = image[sr][sc];
            if (oldColor != color)
            {
                DFS(image, sr, sc, oldColor, color);
            }
            return image;
        }
        public static void DFS(int[][] image, int r, int c, int prevColor, int newColor)
        {
            if (image[r][c] == prevColor)
            {
                image[r][c] = newColor;
                if (r > 1)
                    DFS(image, r - 1, c, prevColor, newColor);
                if (c > 1)
                    DFS(image, r, c - 1, prevColor, newColor);
                if (r + 1 < image.Length)
                    DFS(image, r + 1, c, prevColor, newColor);
                if (c + 1 < image[0].Length)
                    DFS(image, r, c + 1, prevColor, newColor);
            }
        }
    }
}

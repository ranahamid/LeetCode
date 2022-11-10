using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    public class _832_Flipping_an_Image
    {
        /// <summary>
        /// Runtime: 211 ms, faster than 39.91% of C# online submissions for Flipping an Image.
        /// Memory Usage: 42.1 MB, less than 63.23% of C# online submissions for Flipping an Image.
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public static int[][] FlipAndInvertImage(int[][] image)
        {
            foreach (var item in image)
            {
                var data = item.Reverse().ToArray();
                var counter = 0;
                foreach (var num in data)
                {
                    item[counter++] = num == 1 ? 0 : 1;
                }
            }
            return image;
        }
    }
}
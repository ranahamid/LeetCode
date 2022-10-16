using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _812
    {
        /// <summary>
        /// Runtime 142 ms Beats 44.44% Memory 36.5 MB Beats 100%
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        public double LargestTriangleArea(int[][] points)
        {
            double result = 0;
            for (int a = 0; a < points.Length; a++)
                for (int b = 0; b < points.Length; b++)
                    for (int c = 0; c < points.Length; c++)
                    {
                        var plus1 = points[a][0] * points[b][1]; //xayb
                        var plus2 = points[b][0] * points[c][1]; //xbyc
                        var plus3 = points[c][0] * points[a][1]; //xcya

                        var minus1 = points[a][0] * points[c][1];  //xayc
                        var minus2 = points[b][0] * points[a][1]; //xbya
                        var minus3 = points[c][0] * points[b][1];// xcyb

                        double current = 0.5 * (plus1 + plus2 + plus3 - minus1 - minus2 - minus3);

                        result = Math.Max(current, result);
                    }
            return result;
        }
    }
}

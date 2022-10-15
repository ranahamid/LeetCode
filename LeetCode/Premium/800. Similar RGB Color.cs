using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _800
    {
        /// <summary>
        /// Runtime 114 ms Beats 100% Sorry, there are not enough accepted submissions to show data Memory 36.9 MB Beats 100%
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public string SimilarRGB(string color)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("#");
            for (int i = 1; i < color.Length; i = i + 2)
            {
                var temp = color[i].ToString() + color[i + 1].ToString();
                var result = GetSimilarColor(temp);
                sb.Append(result);
            }
            return sb.ToString();
        }
        public string GetSimilarColor(string colorCode)
        {
            var value = Convert.ToInt32(colorCode, 16);
            int ans = (int)Math.Round((decimal)(value / 17.0));
            var hex = Convert.ToString(ans, 16);
            return hex + hex;
        }

        public string GetSimilarColor_BruteForce(string colorCode)
        {
            int diff = Int32.MaxValue;
            int ans = -1;
            var value = Convert.ToInt32(colorCode, 16);
            for (int i = 0; i < 16; i++)
            {
                var currentDiff = (int)Math.Pow(i * 17 - value, 2);
                if (currentDiff < diff)
                {
                    ans = i;
                    diff = currentDiff;
                }
            }
            var hex = Convert.ToString(ans, 16);
            return hex + hex;
        }

    }
}

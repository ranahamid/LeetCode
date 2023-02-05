using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2525
    {
        /// <summary>
        /// Runtime: 66 ms, faster than 79.45% of C# online submissions for Categorize Box According to Criteria.
        /// Memory Usage: 37.1 MB, less than 8.68% of C# online submissions for Categorize Box According to Criteria.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="mass"></param>
        /// <returns></returns>
        public string CategorizeBox(int length, int width, int height, int mass)
        { 
            long volume = (long)((long)length * (long)width * (long)height);
            var isBulky = length >= Math.Pow(10, 4) || width >= Math.Pow(10, 4) || height >= Math.Pow(10, 4) || mass >= Math.Pow(10, 4) || volume >= Math.Pow(10, 9);

            var isHeavy = mass >= 100;
            var isBoth = isBulky && isHeavy;
            if (isBoth)
                return "Both";
            var neither = !isBulky && !isHeavy;
            if (neither)
                return "Neither";
            if (isBulky)
                return "Bulky";
            if (isHeavy)
                return "Heavy";
            return "";
        }
    }
}

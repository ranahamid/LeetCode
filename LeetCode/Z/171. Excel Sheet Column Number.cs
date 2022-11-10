using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _171
    {
        /// <summary>
        /// Runtime: 104 ms, faster than 37.69% of C# online submissions for Excel Sheet Column Number.
        /// Memory Usage: 36.7 MB, less than 46.80% of C# online submissions for Excel Sheet Column Number.
        /// </summary>
        /// <param name="columnTitle"></param>
        /// <returns></returns>
        public static int TitleToNumber(string columnTitle)
        {
            var sum = 0;
            for (int i = 0; i < columnTitle.Length; i++)
            {
                sum = sum * 26 + columnTitle[i] - 64;
            }
            return sum;
        }

    }
}

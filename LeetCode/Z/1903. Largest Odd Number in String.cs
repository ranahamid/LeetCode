using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1903
    {
        /// <summary>
        /// Runtime: 145 ms, faster than 35.71% of C# online submissions for Largest Odd Number in String.
        /// Memory Usage: 41.1 MB, less than 51.43% of C# online submissions for Largest Odd Number in String.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string LargestOddNumber(string num)
        {
            int i;
            for (i = num.Length - 1; i >= 0; i--)
            {
                if (num[i] % 2 == 0)
                    continue;
                else
                    break;
            }
            var result = num.Substring(0, i + 1);
            return result;
        }
    }
}

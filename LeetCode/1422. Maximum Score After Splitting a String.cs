using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1422
    {
        /// <summary>
        /// Runtime: 92 ms, faster than 60.00% of C# online submissions for Maximum Score After Splitting a String.
        /// Memory Usage: 43 MB, less than 5.00% of C# online submissions for Maximum Score After Splitting a String.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int maxScore(String s)
        {
            var max = 0;
            for (int i = 1; i < s.Length; i++)
            {
                var firstSub = s.Substring(0, i);
                var secSub = s.Substring(i, s.Length - i);
                var total = firstSub.Where(x => x == '0').Count() + secSub.Where(x => x == '1').Count();
                max = Math.Max(max, total);
            }
            return max;
        }


        /// <summary>
        /// Runtime: 123 ms, faster than 20.00% of C# online submissions for Maximum Score After Splitting a String.
        /// Memory Usage: 35.1 MB, less than 40.00% of C# online submissions for Maximum Score After Splitting a String.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int maxScore_2(String s)
        {
            var totalOnes = s.Where(x => x == '1').Count();
            var totalZeros = 0;
            var max = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == '1')
                {
                    totalOnes--;
                }
                if (s[i] == '0')
                {
                    totalZeros++;
                }
                max = Math.Max(max, totalOnes + totalZeros);
            }
            return max;
        }


    }
}

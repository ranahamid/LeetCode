using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1402
    {
        /// <summary>
        /// Runtime 88 ms Beats 100% Memory 38.1 MB Beats 36%
        /// </summary>
        /// <param name="satisfaction"></param>
        /// <returns></returns>
        public int MaxSatisfaction(int[] satisfaction)
        {
            int result = 0;
            Array.Sort(satisfaction, (a, b) => b.CompareTo(a));
            var sum = 0;
            for (int i = 0; i < satisfaction.Length && satisfaction[i] > -sum; i++)
            {
                sum += satisfaction[i];
                result += sum;

            }
            return result;
        }
    }
}

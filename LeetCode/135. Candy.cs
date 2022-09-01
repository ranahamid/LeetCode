using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _135
    {
        /// <summary>
        /// Runtime: 169 ms, faster than 48.00% of C# online submissions for Candy.
        /// Memory Usage: 41.8 MB, less than 79.27% of C# online submissions for Candy.
        /// </summary>
        /// <param name="ratings"></param>
        /// <returns></returns>
        public int Candy(int[] ratings)
        {
            var length = ratings.Length;
            var result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = 1;
            }
            for (int i = 1; i < length; i++)
            {
                if (ratings[i] > ratings[i - 1])
                {
                    result[i] = result[i - 1] + 1;
                }
            }
            for (int i = length - 1; i > 0; i--)
            {
                if (ratings[i] < ratings[i - 1])
                {
                    result[i - 1] = Math.Max(result[i - 1], result[i] + 1);
                }
            }

            var count = 0;
            for (int i = 0; i < length; i++)
            {
                count += result[i];
            }
            return count;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1103
    {
        /// <summary>
        /// Runtime: 117 ms, faster than 64.86% of C# online submissions for Distribute Candies to People.
        /// Memory Usage: 34.4 MB, less than 94.59% of C# online submissions for Distribute Candies to People.
        /// </summary>
        /// <param name="candies"></param>
        /// <param name="num_people"></param>
        /// <returns></returns>
        public int[] DistributeCandies(int candies, int num_people)
        {
            var counter = 1;

            int sum = 0;
            var result = new int[num_people];
            var index = 0;
            while (candies > 0)
            {
                if (candies - sum > counter)
                {
                    sum += counter;
                    result[index] = result[index] + counter;
                }
                else
                {
                    var remaining = candies - sum;
                    result[index] = result[index] + remaining;
                    break;
                }
                counter++;
                index++;
                if (index >= num_people)
                    index = 0;
            }
            return result.ToArray();
        }
    }
}

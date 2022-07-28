using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _1196
    {
        /// <summary>
        /// Runtime: 93 ms, faster than 94.44% of C# online submissions for How Many Apples Can You Put into the Basket.
        /// Memory Usage: 41.7 MB, less than 16.67% of C# online submissions for How Many Apples Can You Put into the Basket.
        /// </summary>
        /// <param name="weight"></param>
        /// <returns></returns>
        public int MaxNumberOfApples(int[] weight)
        {
            Array.Sort(weight);
            var counter = 0;
            long sum = 0;
            for (int i = 0; i < weight.Length; i++)
            {
                if (sum + weight[i] <= 5000)
                {
                    counter++;
                    sum += weight[i];
                }
                else
                {
                    return counter;
                }
            }
            return counter;
        }
    }
}

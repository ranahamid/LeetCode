using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1431_Kids_With_the_Greatest_Number_of_Candies
    {
        /// <summary>
        /// Runtime: 169 ms, faster than 79.27% of C# online submissions for Kids With the Greatest Number of Candies.
        /// Memory Usage: 44.7 MB, less than 10.98% of C# online submissions for Kids With the Greatest Number of Candies.
        /// </summary>
        /// <param name="candies"></param>
        /// <param name="extraCandies"></param>
        /// <returns></returns>
        public static List<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var max = candies.Max();
            List<bool> result = new List<bool>();
            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies >= max)
                    result.Add(true);
                else
                    result.Add(false);
            }
            return result;
        }
    }
}

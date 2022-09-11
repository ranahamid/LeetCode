using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2261
    {
        /// <summary>
        /// Runtime: 605 ms, faster than 76.92% of C# online submissions for K Divisible Elements Subarrays.
        /// Memory Usage: 123.2 MB, less than 7.69% of C# online submissions for K Divisible Elements Subarrays.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public int CountDistinct(int[] nums, int k, int p)
        {
            var set = new HashSet<string>();
            for (int i = 0; i < nums.Length; i++)
            {
                var s = new StringBuilder();
                var counter = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    s.Append(nums[j] + "/*/*");
                    if (nums[j] % p == 0)
                        counter++;
                    if (counter > k)
                        break;
                    set.Add(s.ToString());
                }
            } 
            Console.WriteLine();
            return set.Count();
        }
    }
}

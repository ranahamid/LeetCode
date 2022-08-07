using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2366
    {
        /// <summary>
        /// Runtime: 280 ms, faster than 100.00% of C# online submissions for Minimum Replacements to Sort the Array.
        /// Memory Usage: 46.8 MB, less than 100.00% of C# online submissions for Minimum Replacements to Sort the Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public long MinimumReplacement(int[] nums)
        {
            var length = nums.Length;
            long result = 0;
            int prevValue = nums[length - 1];
            for (int i = length - 2; i >= 0; i--)
            {
                //suppose current number is 9 and previous number is 3, then we can divide it into 9 / 3 times - 1,
                //in this case prev remains same (No need to update)
                var numOfTimes = nums[i] / prevValue;

                //now suppose if prev number is not divisible by current number,
                //suppose current is 7 prev is 5,
                //so we can divide 7 into
                //2 ,5
                //3, 4
                //out of this 3,4 is best choice
                if (nums[i] % prevValue != 0)
                {
                    numOfTimes++;
                    prevValue = nums[i] / numOfTimes;
                }

                result = result + numOfTimes - 1;
            }
            return result;
        }
    }
}

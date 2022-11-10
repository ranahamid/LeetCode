using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _179_Largest_Number
    {
        /// <summary>
        /// Runtime: 119 ms, faster than 77.78% of C# online submissions for Largest Number.
        /// Memory Usage: 40 MB, less than 88.24% of C# online submissions for Largest Number.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static string LargestNumber(int[] nums)
        {
            var strArray = nums.Select(x => x.ToString()).ToList();
            strArray.Sort((a, b) =>
            {
                return (b + a).CompareTo(a + b);
            });
            return strArray[0] == "0" ? "0" : string.Join("", strArray);
        }

    }
}

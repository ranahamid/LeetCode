using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2154_Keep_Multiplying_Found_Values_by_Two
    {
        /// <summary>
        /// Runtime: 160 ms, faster than 11.77% of C# online submissions for Keep Multiplying Found Values by Two.
        /// Memory Usage: 38.1 MB, less than 73.11% of C# online submissions for Keep Multiplying Found Values by Two.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="original"></param>
        /// <returns></returns>
        public static int FindFinalValue(int[] nums, int original)
        {
            while (nums.Contains(original))
            {
                original = original * 2;
            }
            return original;
        }

    }
}

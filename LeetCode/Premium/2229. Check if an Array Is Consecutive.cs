using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _2229
    {/// <summary>
     /// Runtime: 378 ms, faster than 20.00% of C# online submissions for Check if an Array Is Consecutive.
     /// Memory Usage: 49.2 MB, less than 60.00% of C# online submissions for Check if an Array Is Consecutive.
     /// </summary>
     /// <param name="nums"></param>
     /// <returns></returns>
        public bool IsConsecutive(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] + 1 != nums[i + 1])
                    return false;
            }
            return true;
        }
    }
}

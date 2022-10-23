using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_309
{
    internal class _2401
    {
        /// <summary>
        /// Runtime: 320 ms, faster than 100.00% of C# online submissions for Longest Nice Subarray.
        /// Memory Usage: 50.2 MB, less than 100.00% of C# online submissions for Longest Nice Subarray.
         /// </summary>
         /// <param name="nums"></param>
         /// <returns></returns>
            public int LongestNiceSubarray(int[] nums)
            {
                int j = 1, i = 0, result = 1;
                int number = nums.Length;
                while (j < number)
                {
                    bool isFound = true;
                    int ans = 32;
                    for (int k = j - 1; k >= i && ans >= 1; k--)
                    {
                        if ((nums[j] & nums[k]) > 0)
                        {
                            isFound = false;
                            break;
                        }
                        ans--;
                    }
                    if (isFound)
                    {
                        result = Math.Max(result, j - i + 1);
                        j++;
                    }
                    else
                        i++;
                }
                return result;
            }
        

    }
}

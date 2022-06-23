using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// Runtime: 129 ms, faster than 41.34% of C# online submissions for Sum of All Odd Length Subarrays.
    /// Memory Usage: 37.2 MB, less than 31.10% of C# online submissions for Sum of All Odd Length Subarrays.
    /// </summary>
    internal class _1588_Sum_of_All_Odd_Length_Subarrays
    {
        public static int SumOddLengthSubarrays(int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    sum = sum + arr[j];
                    if ((j - i + 1) % 2 == 1)
                    {
                        result = result + sum;
                    }
                }
            }
            return result;
        }

    }
}

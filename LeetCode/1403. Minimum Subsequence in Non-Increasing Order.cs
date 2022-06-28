using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _1403__Minimum_Subsequence_in_Non_Increasing_Order {
        
        /// <summary>
        /// Runtime: 290 ms, faster than 10.00% of C# online submissions for Minimum Subsequence in Non-Increasing Order.
        /// Memory Usage: 42.4 MB, less than 73.33% of C# online submissions for Minimum Subsequence in Non-Increasing Order.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<int> MinSubsequence(int[] nums) 
        {
            Array.Sort(nums,(n1,n2)=> n2.CompareTo(n1));
            //Array.Sort(nums);
            // nums= nums.Reverse().ToArray();
            var sumTotal = nums.Sum();
            List<int> result = new List<int>();
            var tempSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result.Add(nums[i]);
                tempSum = tempSum + nums[i];
                var restSum = sumTotal - tempSum;
                if (restSum < tempSum)
                {
                    break;
                }
            }

            return result;
        }


    }
}
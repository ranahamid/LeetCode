using System;

namespace LeetCode
{
    public class _485__Max_Consecutive_Ones
    {
        /// <summary>
        /// Runtime: 167 ms, faster than 61.54% of C# online submissions for Max Consecutive Ones.
        /// Memory Usage: 40.7 MB, less than 76.63% of C# online submissions for Max Consecutive Ones.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public  static  int FindMaxConsecutiveOnes(int[] nums)
        {

            int max = 0;
            var counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                    counter++;
                else if (nums[i] == 0)
                {
                    counter = 0;
                }
                max = Math.Max(max, counter);
            }

            return max;
        }

    }
}
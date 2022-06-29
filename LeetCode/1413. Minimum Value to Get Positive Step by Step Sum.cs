using System;

namespace LeetCode
{
    public class _1413__Minimum_Value_to_Get_Positive_Step_by_Step_Sum {
        public int MinStartValue(int[] nums) {
        
            int minVal= 0;
            int sum = 0;
            foreach (var num in nums)
            {
                sum = sum + num;
                minVal = Math.Min(sum, minVal);
            }
            return 1 - minVal;
         
        }
    }
}
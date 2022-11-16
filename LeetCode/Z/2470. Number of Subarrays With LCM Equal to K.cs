using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2470
    {
        public int SubarrayLCM(int[] nums, int k)
        {
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int current = 1;
                for (int j = i; j < nums.Length && k % nums[j] == 0; j++) //    for(int j=i;j<nums.Length ;j++) //accept
                {
                    current = LCM(current, nums[j]);
                    if (current > k)
                        break;
                    if (current == k)
                        counter++;
                }
            }
            return counter;
        }
        public static int LCM(int a, int b)
        {
            int num1, num2;
            if (a > b)
            {
                num1 = a; num2 = b;
            }
            else
            {
                num1 = b; num2 = a;
            }

            for (int i = 1; i < num2; i++)
            {
                int mult = num1 * i;
                if (mult % num2 == 0)
                {
                    return mult;
                }
            }
            return num1 * num2;
        }
    }
}

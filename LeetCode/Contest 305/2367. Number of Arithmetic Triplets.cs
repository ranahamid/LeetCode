using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_305
{
    internal class _2367
    {
        public int ArithmeticTriplets(int[] nums, int diff)
        {
            int n = 0;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (i != j && j != k && k != i)
                        {
                            if (nums[j] - nums[i] == diff && nums[k] - nums[j] == diff)
                            {
                                n++;
                            }
                        }
                    }
                }
            }
            return n;
        }
    }
}

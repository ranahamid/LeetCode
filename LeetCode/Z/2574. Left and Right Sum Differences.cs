using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2574
    {
        public int[] LeftRigthDifference(int[] nums)
        {

            var left = new List<int>();
            var right = new List<int>();

            var sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                left.Add(sum);
                sum += nums[i];
            }

            sum = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                right.Add(sum);
                sum += nums[i];
            }
            right.Reverse();
            var result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {

                result[i] = Math.Abs(left[i] - right[i]);

            }
            return result;
        }
    }
}

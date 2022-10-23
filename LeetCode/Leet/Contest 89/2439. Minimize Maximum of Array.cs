using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_89
{
    internal class _2439
    {
        ///Runtime 457 ms Beats 100% Sorry, there are not enough accepted submissions to show data Memory 48.9 MB Beats 100%
        public int MinimizeArrayValue(int[] nums)
        {
            var answer = new int[nums.Length];
            double result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result += nums[i];
                double avg = (double)result / (double)(i + 1);
                answer[i] = (int)Math.Ceiling(avg);
            }
            return answer.Max();
        }
    }
}

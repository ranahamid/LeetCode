using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest__83
{
    internal class _6129
    {
        public long ZeroFilledSubarray(int[] nums)
        {
            List<int> list = new List<int>();
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    sum++;
                else
                {
                    if (sum != 0)
                    {
                        list.Add(sum);
                    }
                    sum = 0;
                }
            }
            if (sum != 0)
            {
                list.Add(sum);
            } 
            long result = 0;
            foreach (var n in list)
            {
                result += GetNSum(n);
            }
            return result;

        }
        public static long GetNSum(int n)
        {
            long a = (long)((long)n * ((long)n + 1)) / (long)2;
            return a;
        }
    }
}

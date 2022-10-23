using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_302
{
    internal class _6164
    {
        public static int MaximumSum(int[] nums)
        {
            int max = -1;
            int temp = 0;
            Dictionary<int, int> mp = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                temp = GetDigitSum(nums[i]);
                if (mp.ContainsKey(temp))
                {
                    if (nums[i] + mp[temp] > max)
                    {
                        max = nums[i] + mp[temp];
                    }
                    mp[temp] = Math.Max(nums[i], mp[temp]);
                }
                else
                {
                    mp[temp] = nums[i];
                }
            }
            return max;
        }
        public static int GetDigitSum(int source)
        {
            int sum = 0;
            while (source > 0)
            {
                sum += (int)(source % 10);
                source = source / 10;
            }
            return sum;
        }

    }
}

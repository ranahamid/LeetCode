using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _75
    {
        public void SortColors(int[] nums)
        {
            int current = 0, p0 = 0;
            int p2 = nums.Length - 1;

            while (current <= p2)
            {
                if (nums[current] == 0)
                {
                    (nums[current], nums[p0]) = (nums[p0], nums[current]);
                    current++;
                    p0++;
                }
                else if (nums[current] == 2)
                {
                    (nums[current], nums[p2]) = (nums[p2], nums[current]);
                    p2--;
                }
                else
                {
                    current++;
                }
            }

        }
        #region Dummy
        public void SortColors_Cheat(int[] nums)
        {
            Array.Sort(nums);
        }
        #endregion
    }
}
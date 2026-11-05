using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _3731
    {
        public IList<int> FindMissingElements(int[] nums)
        {
            List<int> result = new List<int>();
            var min = nums[0];
            var max = nums[0];
            foreach (var num in nums)
            {
                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
            }
            for (int i = min; i <= max; i++)
            {
                if (!nums.Contains(i))
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}

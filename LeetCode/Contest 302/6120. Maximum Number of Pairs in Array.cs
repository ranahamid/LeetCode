using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_302
{
    internal class _6120
    {
        public static int[] NumberOfPairs(int[] nums)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (result.ContainsKey(item))
                {
                    result[item]++;
                }
                else
                {
                    result[item] = 1;
                }
            }
            var res1 = 0;
            var res2 = 0;
            foreach (var item in result)
            {
                res1 = res1 + (item.Value / 2);
                if (item.Value % 2 == 1)
                {
                    res2++;
                }
            }
            return new int[] { res1, res2 };
        }
    }
}

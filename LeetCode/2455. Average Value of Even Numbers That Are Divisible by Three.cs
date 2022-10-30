using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2455
    {
        public int AverageValue(int[] nums)
        {
            long sum = 0;
            int counter = 0;
            foreach (var item in nums)
            {
                if (item % 2 == 0 && item % 3 == 0)
                {
                    sum += item;
                    counter++;
                }
            }
            if (counter == 0)
                return 0;
            return (int)sum / counter;
        }
    }
}

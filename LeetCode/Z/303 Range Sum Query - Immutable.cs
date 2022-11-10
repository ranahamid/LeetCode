using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{

    /// <summary>
    /// Runtime: 247 ms, faster than 36.48% of C# online submissions for Range Sum Query - Immutable.
    /// Memory Usage: 55.1 MB, less than 80.65% of C# online submissions for Range Sum Query - Immutable.
    /// </summary>
    public class NumArray
    {
        private int[] array;
        public NumArray(int[] nums)
        {
            array = nums;
        }

        public int SumRange(int left, int right)
        {
            int result = 0;
            for (int i = left; i <= right; i++)
            {
                result = result + array[i];
            }
            return result;
        }
    }
}

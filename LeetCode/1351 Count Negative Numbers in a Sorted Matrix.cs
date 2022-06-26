using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// Runtime: 115 ms, faster than 73.09% of C# online submissions for Count Negative Numbers in a Sorted Matrix.
    /// Memory Usage: 40 MB, less than 69.82% of C# online submissions for Count Negative Numbers in a Sorted Matrix.
    /// </summary>
    internal class _1351_Count_Negative_Numbers_in_a_Sorted_Matrix
    {
        public int CountNegatives(int[][] grid)
        {
            var counter = 0;
            foreach (var item in grid)
            {
                foreach (var number in item)
                {
                    if (number < 0)
                        counter++;
                }
            }
            return counter;
        }
    }
}

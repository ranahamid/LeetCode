using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CodeSignal
{
    internal class adjacent_elements_that_has_the_largest_product
    {
        int solution(int[] inputArray)
        {
            var max = Int32.MinValue;
            for(int i=0; i < inputArray.Length-1; i++)
            {
                max = Math.Max(max, inputArray[i] * inputArray[i + 1]);
            }
            return max;
        }

    }
}

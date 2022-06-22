using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1342_Number_of_Steps_to_Reduce_a_Number_to_Zero
    {
        /// <summary>
        /// Runtime: 26 ms, faster than 78.00% of C# online submissions for Number of Steps to Reduce a Number to Zero.
        /// Memory Usage: 26.5 MB, less than 12.51% of C# online submissions for Number of Steps to Reduce a Number to Zero.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int NumberOfSteps(int num)
        {
            var counter = 0;
            while (num != 0)
            {
                if (num % 2 == 0)
                    num = num / 2;
                else
                    num--;
                counter++;
            }
            return counter;
        }
    }
}

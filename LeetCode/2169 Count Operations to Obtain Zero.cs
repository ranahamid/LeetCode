using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2169_Count_Operations_to_Obtain_Zero
    {
        /// <summary>
        /// Runtime: 26 ms, faster than 88.80% of C# online submissions for Count Operations to Obtain Zero.
        /// Memory Usage: 25.3 MB, less than 38.40% of C# online submissions for Count Operations to Obtain Zero.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int CountOperations(int num1, int num2)
        {
            var counter = 0;
            while (num1 != 0 && num2 != 0)
            {
                if (num1 >= num2)
                {
                    num1 = num1 - num2;
                }
                else
                {
                    num2 = num2 - num1;
                }
                counter++;
            }
            return counter;
        }

    }
}

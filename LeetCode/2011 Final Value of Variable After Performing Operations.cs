using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2011_Final_Value_of_Variable_After_Performing_Operations
    {

        /// <summary>
        /// Runtime: 93 ms, faster than 85.46% of C# online submissions for Final Value of Variable After Performing Operations.
        /// Memory Usage: 40.1 MB, less than 12.55% of C# online submissions for Final Value of Variable After Performing Operations.
        /// </summary>
        /// <param name="operations"></param>
        /// <returns></returns>
        public static int FinalValueAfterOperations(string[] operations)
        {
            var result = 0;
            foreach (var item in operations)
            {
                if (item == "++X" || item == "X++")
                {
                    result++;
                }
                else if (item == "--X" || item == "X--")
                {
                    result--;
                }
            }
            return result;
        }

    }
}

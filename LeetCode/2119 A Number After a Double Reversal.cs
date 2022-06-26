using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2119_A_Number_After_a_Double_Reversal
    {

        /// <summary>
        /// Runtime: 47 ms, faster than 52.94% of C# online submissions for A Number After a Double Reversal.
        ///Memory Usage: 27 MB, less than 41.18% of C# online submissions for A Number After a Double Reversal.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsSameAfterReversals_2(int num)
        {
            return num == 0 || num % 10 != 0;
        }


        /// <summary>
        /// Runtime: 39 ms, faster than 84.31% of C# online submissions for A Number After a Double Reversal.
        /// Memory Usage: 27.1 MB, less than 41.18% of C# online submissions for A Number After a Double Reversal.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsSameAfterReversals(int num)
        {
            if (num == 0)
                return true;
            if (num % 10 == 0)
                return false;
            return true;
        }
    }
}

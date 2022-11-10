using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1688_Count_of_Matches_in_Tournament
    {



        /// <summary>
        /// Runtime: 20 ms, faster than 92.71% of C# online submissions for Count of Matches in Tournament.
        /// Memory Usage: 25.1 MB, less than 56.25% of C# online submissions for Count of Matches in Tournament.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NumberOfMatches(int n)
        {
            return n - 1;
        }


        /// <summary>
        /// Runtime: 36 ms, faster than 34.38% of C# online submissions for Count of Matches in Tournament.
        ///  Memory Usage: 25 MB, less than 81.25% of C# online submissions for Count of Matches in Tournament.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int NumberOfMatches_2(int n)
        {
            int result = 0;
            while (n != 1)
            {
                result = result + n / 2;
                if (n % 2 == 0)
                {
                    n = n / 2;
                }
                else
                {
                    n = n / 2 + 1;
                }

            }
            return result;
        }

    }
}

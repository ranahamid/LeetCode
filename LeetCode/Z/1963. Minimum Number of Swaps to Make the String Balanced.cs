using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1963
    {
        /// <summary>
        /// Runtime: 105 ms, faster than 91.11% of C# online submissions for Minimum Number of Swaps to Make the String Balanced.
        ///  Memory Usage: 69.3 MB, less than 42.22% of C# online submissions for Minimum Number of Swaps to Make the String Balanced.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int MinSwaps_(string s)
        {
            var counter = 0;
            foreach (var item in s)
            {
                if (item == '[')
                    counter++;
                else
                {
                    if (counter > 0)
                    {
                        counter--;
                    }
                }
            }
            return (counter + 1) / 2;
        }
        /// <summary>
        /// Runtime: 152 ms, faster than 44.44% of C# online submissions for Minimum Number of Swaps to Make the String Balanced.
        /// Memory Usage: 70.3 MB, less than 13.33% of C# online submissions for Minimum Number of Swaps to Make the String Balanced.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int MinSwaps_2(string s)
        {
            var counter = 0;
            foreach (var item in s)
            {
                if (item == '[')
                    counter++;
                else
                {
                    if (counter > 0)
                    {
                        counter--;
                    }
                }
            }
            if (counter % 2 == 0)  //can exclude these lines
                return counter / 2; //can exclude these lines
            else //can exclude these lines
                return (counter + 1) / 2;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1374_Generate_a_String_With_Characters_That_Have_Odd_Counts
    {
        /// <summary>
        /// Runtime: 114 ms, faster than 22.37% of C# online submissions for Generate a String With Characters That Have Odd Counts.
        /// Memory Usage: 35.5 MB, less than 77.63% of C# online submissions for Generate a String With Characters That Have Odd Counts.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string GenerateTheString(int n)
        {
            var isEven = n % 2 == 0;
            var array = new char[n];
            var len = n;
            if (isEven)
            {
                len--;
            }
            for (int i = 0; i < len; i++)
            {
                array[i] = 'a';
            }
            if (isEven)
            {
                array[n - 1] = 'b';
            }
            return new string(array);
        }
    }
}

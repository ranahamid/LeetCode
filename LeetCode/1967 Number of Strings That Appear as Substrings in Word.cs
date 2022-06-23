using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1967_Number_of_Strings_That_Appear_as_Substrings_in_Word
    {

        /// <summary>
        /// Runtime: 143 ms, faster than 26.67% of C# online submissions for Number of Strings That Appear as Substrings in Word.
        /// Memory Usage: 37.5 MB, less than 95.00% of C# online submissions for Number of Strings That Appear as Substrings in Word.
        /// </summary>
        /// <param name="patterns"></param>
        /// <param name="word"></param>
        /// <returns></returns>

        public static int NumOfStrings(string[] patterns, string word)
        {
            var counter = 0;
            foreach (var item in patterns)
            {
                if (word.Contains(item))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}

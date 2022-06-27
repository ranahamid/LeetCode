using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2278_Percentage_of_Letter_in_String
    {
        /// <summary>
        /// Runtime: 167 ms, faster than 5.30% of C# online submissions for Percentage of Letter in String.
        //// Memory Usage: 36.9 MB, less than 84.85% of C# online submissions for Percentage of Letter in String.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="letter"></param>
        /// <returns></returns>
        public static int PercentageLetter(string s, char letter)
        {
            var schars = s.ToCharArray();
            var occuCount = schars.Where(x => x == letter).Count();
            var percentage = (int)(occuCount / (double)schars.Length * 100);
            return percentage;
        }
    }
}

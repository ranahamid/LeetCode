using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _744
    {
        /// <summary>
        /// Linear Scan [Accepted]
        /// Runtime: 182 ms, faster than 27.86% of C# online submissions for Find Smallest Letter Greater Than Target.
        /// Memory Usage: 40.3 MB, less than 75.95% of C# online submissions for Find Smallest Letter Greater Than Target.
        /// </summary>
        /// <param name="letters"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static char NextGreatestLetter(char[] letters, char target)
        {
            foreach (var item in letters)
            {
                if (item > target)
                    return item;
            }
            return letters[0];
        }
        /// <summary>
        /// Record Letters Seen 
        /// </summary>
        /// <param name="letters"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static char NextGreatestLetter_2(char[] letters, char target)
        {
            var seen = new int[26];
            foreach (var item in letters)
            {
                seen[item - 'a'] = 1;
                if (seen.Where(x => x == 1).Count() == 26)
                    break;
            }
            while (true)
            {
                target++;//z-> a_> b-> c
                if (target > 'z')
                    target = 'a';
                if (seen[target - 'a'] == 1) //seen['c'-'a']= seen[2]==1, answer is c
                {
                    return target;
                }
            }
        }
    }
}

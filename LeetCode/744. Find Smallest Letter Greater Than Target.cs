using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _744
    {
        public static char NextGreatestLetter(char[] letters, char target)
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

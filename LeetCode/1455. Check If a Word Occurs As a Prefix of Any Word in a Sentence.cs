using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1455
    {
        public static int IsPrefixOfWord(string sentence, string searchWord)
        {
            var counter = 1;
            var sChars = sentence.Split(' ');
            foreach (var word in sChars)
            {
                if (word.StartsWith(searchWord))
                {
                    return counter;
                }
                counter++;
            }
            return -1;
        }
    }
}

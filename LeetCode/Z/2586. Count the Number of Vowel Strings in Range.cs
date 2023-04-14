using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2586
    {
        public int VowelStrings(string[] words, int left, int right)
        {

            var count = 0;
            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            for (int i = left; i <= right; i++)
            {
                var len = words[i].Length;
                if (vowels.Contains(words[i][0]) && vowels.Contains(words[i][len - 1]))
                {
                    count++;
                }
            }
            return count;
        }
    }
}

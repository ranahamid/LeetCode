using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _1165
    {
        public int CalculateTime(string keyboard, string word)
        {
            var sum = 0;
            var currentPosition = 0;
            for (int i = 0; i < word.Length; i++)
            {
                var index = keyboard.IndexOf(word[i]);

                var firstLen = Math.Abs(index - currentPosition);
                sum += firstLen;

                currentPosition = index;



            }
            return sum;
        }
    }
}

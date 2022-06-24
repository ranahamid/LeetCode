using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2108_Find_First_Palindromic_String_in_the_Array
    {
        /// <summary>
        /// Runtime: 151 ms, faster than 63.40% of C# online submissions for Find First Palindromic String in the Array.
        /// Memory Usage: 40.5 MB, less than 50.33% of C# online submissions for Find First Palindromic String in the Array.
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public string FirstPalindrome(string[] words)
        {
            foreach (var word in words)
            {
                var chars = word.ToCharArray().Reverse().ToArray();
                if (word == new string(chars))
                {
                    return word;
                }
            }
            return "";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1880_Check_if_Word_Equals_Summation_of_Two_Words
    {
        /// <summary>
        /// Runtime: 108 ms, faster than 38.18% of C# online submissions for Check if Word Equals Summation of Two Words.
        /// Memory Usage: 37.3 MB, less than 69.09% of C# online submissions for Check if Word Equals Summation of Two Words.
        /// </summary>
        /// <param name="firstWord"></param>
        /// <param name="secondWord"></param>
        /// <param name="targetWord"></param>
        /// <returns></returns>
        public static bool IsSumEqual(string firstWord, string secondWord, string targetWord)
        {
            var first = GetDigitValue(firstWord);
            var sec = GetDigitValue(secondWord);
            var final = GetDigitValue(targetWord);

            return first + sec == final;
        }


        public static int GetDigitValue(string firstWord)
        {
            var firstChars = firstWord.ToCharArray();
            for (int i = 0; i < firstChars.Length; i++)
            {
                firstChars[i] = (char)(firstChars[i] - 97 + 48);
            }
            int.TryParse(new string(firstChars), out int firstNumber);

            return firstNumber;
        }

    }
}

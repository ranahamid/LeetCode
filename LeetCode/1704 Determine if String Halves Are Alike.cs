using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1704_Determine_if_String_Halves_Are_Alike
    {


        /// <summary>
        /// Runtime: 83 ms, faster than 75.61% of C# online submissions for Determine if String Halves Are Alike.
        /// Memory Usage: 37.9 MB, less than 25.61% of C# online submissions for Determine if String Halves Are Alike.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool HalvesAreAlike(string s)
        {
            List<char> vowelList = new List<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            var chars = s.ToCharArray();
            var len = chars.Length;
            var halfLen = len / 2;
            var firstVowel = 0;
            var secondVowel = 0;
            for (int i = 0; i < len; i++)
            {
                if (vowelList.Contains(chars[i]))
                {
                    if (i < halfLen)
                    {
                        firstVowel++;
                    }
                    else
                    {
                        secondVowel++;
                    }
                }

            }
            if (firstVowel == secondVowel)
                return true;
            return false;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _58_Length_of_Last_Word
    {

        /// <summary> 
        /// Runtime: 85 ms, faster than 52.77% of C# online submissions for Length of Last Word.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int LengthOfLastWord(string s)
        {
            int length = 0;
            var chars = s.ToCharArray();
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                if (length > 0 && chars[i] == ' ')
                    break;
                else if (chars[i] != ' ')
                {
                    length++;
                }

            }
            return length;
        }

        /// <summary>
        /// Runtime: 123 ms, faster than 7.68% of C# online submissions for Length of Last Word. 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int LengthOfLastWord_2(string s)
        {
            int length = 0;
            var chars = s.ToCharArray();
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                if (length > 0 && chars[i] == ' ')
                    break;
                if (length == 0 && chars[i] == ' ')
                    continue;
                if (chars[i] != ' ')
                {
                    length++;
                }

            }
            return length;
        }
    }
}

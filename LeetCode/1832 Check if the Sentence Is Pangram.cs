using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1832_Check_if_the_Sentence_Is_Pangram
    {
        /// <summary>
        /// Runtime: 115 ms, faster than 24.50% of C# online submissions for Check if the Sentence Is Pangram.
        /// Memory Usage: 36.6 MB, less than 50.99% of C# online submissions for Check if the Sentence Is Pangram.
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public static bool CheckIfPangram(string sentence)
        {
            int[] result = new int[26];
            var data = sentence.ToArray();
            for (int i = 0; i < data.Length; i++)
            {
                var index = (int)data[i] - 97;
                result[index]++;
            }
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == 0)
                    return false;
            }
            return true;
        }

    }
}

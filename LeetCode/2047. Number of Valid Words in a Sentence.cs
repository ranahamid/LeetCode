using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2047
    {
        /// <summary>
        /// Runtime: 71 ms, faster than 94.34% of C# online submissions for Number of Valid Words in a Sentence.
        /// Memory Usage: 38.3 MB, less than 20.75% of C# online submissions for Number of Valid Words in a Sentence.
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public int CountValidWords(string sentence)
        {
            var words = sentence.Split(' ');
            var count = 0; var puncList = new HashSet<char> { '!', '.', ',' };
            foreach (var word in words)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    if (IsValid(word, puncList))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public static bool IsValid(string word, HashSet<char> puncList)
        {
            bool isHyphen = false;
            for (int i = 0; i < word.Length; i++)
            {
                var ch = word[i];
                if (char.IsDigit(ch))
                {
                    return false;
                }
                if (char.IsLetter(ch))
                {
                    continue;
                }
                if (puncList.Contains(ch))
                {
                    if (i != word.Length - 1)
                        return false;
                }
                if (ch == '-')
                {
                    if (isHyphen || i == 0 || i == word.Length - 1 || !char.IsLetter(word[i - 1]) || !char.IsLetter(word[i + 1]))
                        return false; 
                    isHyphen = true;
                }
            }
            return true;
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Z
{
    public class _884__Uncommon_Words_from_Two_Sentences
    {

        /// <summary>
        /// Runtime: 219 ms, faster than 31.25% of C# online submissions for Uncommon Words from Two Sentences.
        /// Memory Usage: 42.9 MB, less than 28.13% of C# online submissions for Uncommon Words from Two Sentences.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static string[] UncommonFromSentences(string s1, string s2)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            var s1Array = s1.Split(' ');
            var s2Array = s2.Split(' ');

            foreach (var word in s1Array)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word]++;
                }
                else
                {
                    dictionary[word] = 1;
                }
            }
            foreach (var word in s2Array)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word]++;
                }
                else
                {
                    dictionary[word] = 1;
                }
            }

            var list = dictionary.Where(x => x.Value == 1).Select(x => x.Key).ToArray();
            return list;
        }
    }
}
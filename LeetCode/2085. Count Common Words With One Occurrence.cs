using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _2085__Count_Common_Words_With_One_Occurrence {
        
        /// <summary>
        /// Runtime: 163 ms, faster than 33.85% of C# online submissions for Count Common Words With One Occurrence.
        /// Memory Usage: 40.6 MB, less than 66.15% of C# online submissions for Count Common Words With One Occurrence.
        /// </summary>
        /// <param name="words1"></param>
        /// <param name="words2"></param>
        /// <returns></returns>
        public static int CountWords(string[] words1, string[] words2)
        {

            var first = GetStrDic(words1);
            var second = GetStrDic(words2);
            
            var counter = 0;
            foreach (var item in first)
            {
                if (second.Contains(item))
                    counter++;
            }
            return counter;
        }

        public static List<string> GetStrDic(string[] words)
        {
            Dictionary<string, int> first = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (first.ContainsKey(word))
                {
                    first[word]++;
                }
                else
                {
                    first[word] = 1;
                }
            }

            var result = first.Where(x => x.Value == 1).Select(x=>x.Key).ToList();
            return result;
        }

    }
}
using System.Collections.Generic;

namespace LeetCode
{
    public class _1160__Find_Words_That_Can_Be_Formed_by_Characters {
        
        
        /// <summary>
        /// Runtime: 191 ms, faster than 37.78% of C# online submissions for Find Words That Can Be Formed by Characters.
        /// Memory Usage: 42.1 MB, less than 82.22% of C# online submissions for Find Words That Can Be Formed by Characters.
        /// </summary>
        /// <param name="words"></param>
        /// <param name="chars"></param>
        /// <returns></returns>
        public static int CountCharacters(string[] words, string chars)
        {
            int count = 0;
            foreach (var word in words)
            {
                var result = isWordAccept(word, chars);
                if (result)
                {
                    var Schars = word.ToCharArray();
                    count += Schars.Length;
                }
            }

            return count;
        }

        public static bool isWordAccept(string word, string chars)
        {
            var schars = chars.ToCharArray();
          
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            for (int i = 0; i < schars.Length; i++)
            {
                if (dictionary.ContainsKey(schars[i]))
                    dictionary[schars[i]]++;
                else
                {
                    dictionary[schars[i]] = 1;
                }
            }

            var wordChar = word.ToCharArray();
            foreach (var item in wordChar)
            {
                if (dictionary.Count > 0 && dictionary.ContainsKey(item))
                {
                    var currentValu = dictionary[item];
                    if (currentValu > 1)
                        dictionary[item]--;
                    else
                        dictionary.Remove(item);
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

    }
}
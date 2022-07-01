using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _2068__Check_Whether_Two_Strings_are_Almost_Equivalent {
               /// <summary>
        /// Runtime: 130 ms, faster than 14.63% of C# online submissions for Check Whether Two Strings are Almost Equivalent.
        /// Memory Usage: 37.2 MB, less than 80.49% of C# online submissions for Check Whether Two Strings are Almost Equivalent.
        /// </summary>
        /// <param name="word1"></param>
        /// <param name="word2"></param>
        /// <returns></returns>
        public static bool CheckAlmostEquivalent(string word1, string word2)
        {
            var first = GetFrquencty(word1);
            var second = GetFrquencty(word2);
            var counter = 0;
            foreach (var item in first)
            {
                var secondCount = 0;
                if (second.ContainsKey(item.Key))
                {
                    secondCount = second[item.Key];
                    second.Remove(item.Key);
                }
                if (Math.Abs(secondCount - item.Value) > 3)
                {
                    return false;
                }
            }
//second
            foreach (var item in second)
            {
                var firstCount = 0;
                if (first.ContainsKey(item.Key))
                {
                    firstCount = first[item.Key];
                    first.Remove(item.Key);
                }
                if (Math.Abs(firstCount - item.Value) > 3)
                {
                    return false;
                }
            }
            
            return true;
        }

        public static Dictionary<char, int> GetFrquencty(string word)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            if (!string.IsNullOrEmpty(word))
            {
                var sChars = word.ToCharArray();
                for (int i = 0; i < sChars.Length; i++)
                {
                    if (dictionary.ContainsKey(sChars[i]))
                    {
                        dictionary[sChars[i]]++;
                    }
                    else
                    {
                        dictionary[sChars[i]] = 1;
                    }
                }
            }
            return dictionary;
        }

    }
}
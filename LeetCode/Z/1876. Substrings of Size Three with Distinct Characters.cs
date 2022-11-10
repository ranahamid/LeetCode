using System.Collections.Generic;

namespace LeetCode.Z
{
    public class _1876__Substrings_of_Size_Three_with_Distinct_Characters
    {


        #region solution 1


        /// <summary>
        /// Runtime: 103 ms, faster than 23.85% of C# online submissions for Substrings of Size Three with Distinct Characters.
        /// Memory Usage: 34.9 MB, less than 60.55% of C# online submissions for Substrings of Size Three with Distinct Characters.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int CountGoodSubstrings_2(string s)
        {
            var sChars = s.ToCharArray();
            var set = new List<string>();
            var sum = 0;
            if (sChars.Length >= 3)
            {
                for (int i = 0; i < sChars.Length - 2; i++)
                {
                    if (s[i] != s[i + 1] && s[i] != s[i + 2] && s[i + 1] != s[i + 2])
                    {
                        sum++;
                    }
                }
            }

            return sum;

        }

        #endregion

        #region  solution 1




        /// <summary>
        /// Runtime: 115 ms, faster than 13.76% of C# online submissions for Substrings of Size Three with Distinct Characters.
        /// Memory Usage: 37 MB, less than 7.34% of C# online submissions for Substrings of Size Three with Distinct Characters.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int CountGoodSubstrings(string s)
        {
            var sChars = s.ToCharArray();
            var set = new List<string>();
            if (sChars.Length >= 3)
            {
                for (int i = 0; i < sChars.Length - 2; i++)
                {
                    var word = new char[3];
                    word[0] = s[i];
                    word[1] = s[i + 1];
                    word[2] = s[i + 2];
                    set.Add(new string(word));
                }
            }

            var sum = 0;
            for (int i = 0; i < set.Count; i++)
            {
                if (UniqueSet(set[i]))
                    sum++;
            }
            return sum;
        }

        public static bool UniqueSet(string word)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            var sChars = word.ToCharArray();
            for (int i = 0; i < sChars.Length; i++)
            {
                if (dictionary.ContainsKey(sChars[i]))
                {

                    return false;
                    //dictionary[sChars[i]]++;
                }
                else
                {
                    dictionary[sChars[i]] = 1;
                }
            }
            return true;
        }

        #endregion

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _336
    {
        /// <summary>
        /// Runtime: 1708 ms, faster than 23.91% of C# online submissions for Palindrome Pairs.
        /// Memory Usage: 67.3 MB, less than 47.83% of C# online submissions for Palindrome Pairs.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public bool IsValidPalindromeCheck(string word, int left, int right)
        {
            while (left < right)
            {
                if (word[left] != word[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }
        public IList<IList<int>> PalindromePairs(string[] words)
        {
            var set = new Dictionary<string, int>();
            var counter = 0;
            foreach (var item in words)
            {
                set.TryAdd(new string(item.Reverse().ToArray()), counter++);
            }
            List<IList<int>> result = new List<IList<int>>();
            for (int currentIndex = 0; currentIndex < words.Length; currentIndex++)
            {
                //case 1
                var word = words[currentIndex];
                if (set.ContainsKey(word) && set[word] != currentIndex)
                {
                    result.Add(new List<int> { set[word], currentIndex });
                }
                //case 2
                for (int i = 0; i < word.Length; i++)
                {
                    var suffix = word.Substring(i + 1);
                    if (IsValidPalindromeCheck(word, 0, i))
                    {
                        if (set.ContainsKey(suffix))
                        {
                            result.Add(new List<int> { set[suffix], currentIndex });
                        }
                    }
                }
                //case 3
                for (int i = 0; i < word.Length; i++)
                {
                    var prefix = word.Substring(0, i);
                    if (IsValidPalindromeCheck(word, i, word.Length - 1))
                    {
                        if (set.ContainsKey(prefix))
                        {
                            result.Add(new List<int> { currentIndex, set[prefix] });
                        }
                    }
                }
            }
            return result;
        }
        #region ACCEPTED
        /// <summary>
        /// Runtime: 1095 ms, faster than 78.26% of C# online submissions for Palindrome Pairs.
        /// Memory Usage: 73.6 MB, less than 34.78% of C# online submissions for Palindrome Pairs.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public bool IsValidPalindrome_AC(string word, int left, int right)
        {
            while (left < right)
            {
                if (word[left] != word[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }
        public IList<IList<int>> PalindromePairs_AC(string[] words)
        {
            List<IList<int>> result = new List<IList<int>>();
            if (words == null || words.Length == 0)
                return result;
            var set = new Dictionary<string, int>();
            var counter = 0;
            foreach (var item in words)
            {
                set.TryAdd(new string(item.Reverse().ToArray()), counter++);
            }

            for (int i = 0; i < words.Length; i++)
            {
                //case 1
                var currentIndex = i;
                var word = words[i];


                if (set.ContainsKey(word) && set[word] != currentIndex)
                {
                    var revWord = new string(word.Reverse().ToArray());
                    if (revWord != word)
                        result.Add(new List<int> { set[word], currentIndex });
                }
                //case 2
                for (int j = word.Length - 1; j >= 0; j--)
                {
                    var sub = word.Substring(0, j);
                    if (IsValidPalindrome_AC(word, j, word.Length - 1) && set.ContainsKey(sub))
                    {
                        result.Add(new List<int> { currentIndex, set[sub] });
                    }
                }
                //case 3
                for (int j = 0; j < word.Length; j++)
                {
                    var sub = word.Substring(j + 1);
                    if (IsValidPalindrome_AC(word, 0, j) && set.ContainsKey(sub))
                    {
                        result.Add(new List<int> { set[sub], currentIndex });
                    }
                }
            }
            return result;
        }
        #endregion
        #region TLE
        public List<string> AllValidPrefix(string word)
        {
            List<string> allValidPrefix = new List<string>();
            for (int i = 0; i < word.Length; i++)
            {
                if (IsValidPalindromeBetween(word, i, word.Length - 1))
                {
                    allValidPrefix.Add(word.Substring(0, i));
                }
            }
            return allValidPrefix;
        }
        public List<string> AllValidSuffix(string word)
        {
            List<string> allValidSuffix = new List<string>();
            for (int i = 0; i < word.Length; i++)
            {
                if (IsValidPalindromeBetween(word, 0, i))
                {
                    allValidSuffix.Add(word.Substring(i + 1, word.Length - i - 1));
                }
            }
            return allValidSuffix;
        }
        public bool IsValidPalindromeBetween(string word, int left, int right)
        {
            while (left < right)
            {
                if (word[left] != word[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }
        public IList<IList<int>> PalindromePairs_TLE(string[] words)
        {
            var set = new Dictionary<string, int>();
            var counter = 0;
            foreach (var item in words)
            {
                set.TryAdd(item, counter++);
            }
            List<IList<int>> result = new List<IList<int>>();
            foreach (var item in set)
            {
                //case 1
                var currentIndex = item.Value;
                var word = item.Key;
                var revWord = new string(word.Reverse().ToArray());
                if (set.ContainsKey(revWord) && set[revWord] != currentIndex)
                {
                    result.Add(new List<int> { set[revWord], currentIndex });
                }
                //case 2
                var allSuffix = AllValidSuffix(word);
                foreach (var suffix in allSuffix)
                {
                    revWord = new string(suffix.Reverse().ToArray());
                    if (set.ContainsKey(revWord))
                    {
                        result.Add(new List<int> { set[revWord], currentIndex });
                    }
                }
                //case 3
                var allPrefix = AllValidPrefix(word);
                foreach (var prefix in allPrefix)
                {
                    revWord = new string(prefix.Reverse().ToArray());
                    if (set.ContainsKey(revWord))
                    {
                        result.Add(new List<int> { currentIndex, set[revWord] });
                    }
                }
            }
            return result;
        }
        #endregion
    }
}

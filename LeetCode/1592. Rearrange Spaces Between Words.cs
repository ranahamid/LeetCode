using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1592
    {
        /// <summary>
        /// Runtime: 136 ms, faster than 25.64% of C# online submissions for Rearrange Spaces Between Words.
        //// Memory Usage: 35.9 MB, less than 23.08% of C# online submissions for Rearrange Spaces Between Words.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string ReorderSpaces_3(string text)
        {
            var words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var spaces = text.Count(char.IsWhiteSpace);
            var gap = words.Length == 1 ? 0 : spaces / (words.Length - 1);
            var result = string.Join(new string(' ', gap), words) + new string(' ', spaces - gap * (words.Length - 1));
            return result;
        }
        /// <summary>
        /// Runtime: 140 ms, faster than 23.08% of C# online submissions for Rearrange Spaces Between Words.
        /// Memory Usage: 35.5 MB, less than 79.49% of C# online submissions for Rearrange Spaces Between Words.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string ReorderSpaces_2(string text)
        {
            var words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var spaces = text.Count(char.IsWhiteSpace);
            var wordCount = words.Length;
            var result = new StringBuilder();
            if (wordCount > 1)
            {
                var equal = spaces / (wordCount - 1);
                var remaining = spaces - equal * (wordCount - 1);


                for (int i = 0; i < words.Length; i++)
                {
                    result.Append(words[i]);
                    if (i < words.Length - 1)
                    {
                        for (int j = 0; j < equal; j++)
                            result.Append(' ');
                    }
                }
                for (int j = 0; j < remaining; j++)
                    result.Append(' ');

            }
            else
            {
                for (int i = 0; i < words.Length; i++)
                {
                    result.Append(words[i]);
                }
                for (int j = 0; j < spaces; j++)
                    result.Append(' ');

            }
            return result.ToString();
        }
        /// <summary>
        /// Runtime: 85 ms, faster than 87.18% of C# online submissions for Rearrange Spaces Between Words.
        /// Memory Usage: 36.8 MB, less than 15.38% of C# online submissions for Rearrange Spaces Between Words.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string ReorderSpaces_1(string text)
        {
            var words = text.Split(' ');
            var wordCount = 0;
            var wordList = new List<string>();
            foreach (var item in words)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    wordCount++;
                    wordList.Add(item);
                }
            }
            var spaces = 0;
            foreach (var ch in text)
            {
                if (ch == ' ')
                    spaces++;
            }
            var result = new StringBuilder();
            if (wordCount > 1)
            {
                var equal = spaces / (wordCount - 1);
                var remaining = spaces - equal * (wordCount - 1);


                for (int i = 0; i < wordList.Count; i++)
                {
                    result.Append(wordList[i]);
                    if (i < wordList.Count - 1)
                    {
                        for (int j = 0; j < equal; j++)
                            result.Append(' ');
                    }
                }
                for (int j = 0; j < remaining; j++)
                    result.Append(' ');

            }
            else
            {
                for (int i = 0; i < wordList.Count; i++)
                {
                    result.Append(wordList[i]);
                }
                for (int j = 0; j < spaces; j++)
                    result.Append(' ');

            }
            return result.ToString();
        }
    }
}

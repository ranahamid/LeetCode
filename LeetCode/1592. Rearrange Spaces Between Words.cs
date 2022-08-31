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
        /// Runtime: 85 ms, faster than 87.18% of C# online submissions for Rearrange Spaces Between Words.
        /// Memory Usage: 36.8 MB, less than 15.38% of C# online submissions for Rearrange Spaces Between Words.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string ReorderSpaces(string text)
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

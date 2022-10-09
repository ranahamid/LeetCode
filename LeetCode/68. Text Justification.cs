using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _68
    {
        /// <summary>
        /// Runtime 160 ms Beats 91.94% Memory 43.7 MB Beats 6.16%
        /// </summary>
        /// <param name="words"></param>
        /// <param name="maxWidth"></param>
        /// <returns></returns>
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            var numOfLetters = 0;
            int index = 1;
            var result = new List<string>();
            var current = new List<StringBuilder>();
            foreach (var word in words)
            {
                if (numOfLetters + current.Count + word.Length > maxWidth)
                {
                    var remaining = maxWidth - numOfLetters;
                    for (int i = 0; i < remaining; i++)
                    {
                        if (current.Count == 1)
                            current[0].Append(' ');
                        else
                        {
                            var ind = i % (current.Count - 1);
                            current[ind].Append(' ');
                        }
                    }
                    var sentence = string.Join("", current);
                    result.Add(sentence);
                    current = new List<StringBuilder>();
                    numOfLetters = 0;
                }
                current.Add(new StringBuilder(word));
                numOfLetters += word.Length;
                if (index == words.Length)
                {
                    var final = string.Join(" ", current);
                    var remaining = maxWidth - final.Length;
                    for (int i = 0; i < remaining; i++)
                        final += " ";
                    result.Add(final);
                }
                index++;
            }
            return result;
        }
    }
}

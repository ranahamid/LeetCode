using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _151
    {
        /// <summary>
        /// Runtime: 90 ms, faster than 86.35% of C# online submissions for Reverse Words in a String.
        /// Memory Usage: 39 MB, less than 7.70% of C# online submissions for Reverse Words in a String.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string ReverseWords(string s)
        {
            s = s.Trim();
            var words = s.Split(' ');

            var lsit = words.Reverse().ToArray();
            var result = new List<string>();
            foreach (var word in lsit)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    result.Add(word.Trim());
                }
            }
            var sentence = string.Join(" ", result);
            return sentence;
        }
    }
}

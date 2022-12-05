using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2490
    {
        public bool IsCircularSentence(string sentence)
        {
            var len = sentence.Length;
            if (sentence[0] == sentence[len - 1])
            {
                var words = sentence.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int i = 1; i < words.Length; i++)
                {
                    var first = words[i - 1];
                    var second = words[i];
                    if (first[first.Length - 1] != second[0])
                        return false;
                }
                return true;
            }

            return false;
        }
    }
}

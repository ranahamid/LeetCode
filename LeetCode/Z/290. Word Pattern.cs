using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _290
    {    /// <summary>
         /// https://leetcode.com/problems/word-pattern/
         /// Runtime: 117 ms, faster than 39.50% of C# online submissions for Word Pattern.
         /// Memory Usage: 36.8 MB, less than 35.74% of C# online submissions for Word Pattern.
         /// </summary>
         /// <param name="pattern"></param>
         /// <param name="s"></param>
         /// <returns></returns>

        public static bool WordPattern(string pattern, string s)
        {
            var dicFirst = new Dictionary<char, string>();
            var dicSec = new Dictionary<string, char>();

            var words = s.Split(' ');
            if (words.Length != pattern.Length)
                return false;

            for (int i = 0; i < pattern.Length; i++)
            {
                var currentVal = words[i];
                if (dicFirst.ContainsKey(pattern[i]))
                {
                    var dicVal = dicFirst[pattern[i]];
                    if (!currentVal.Equals(dicVal))
                    {
                        return false;
                    }
                }
                else
                {
                    dicFirst[pattern[i]] = currentVal;
                }
            }
            for (int i = 0; i < words.Length; i++)
            {
                var currentVal = pattern[i];
                if (dicSec.ContainsKey(words[i]))
                {
                    var dicVal = dicSec[words[i]];
                    if (!currentVal.Equals(dicVal))
                    {
                        return false;
                    }
                }
                else
                {
                    dicSec[words[i]] = currentVal;
                }
            }

            return true;

        }



    }
}

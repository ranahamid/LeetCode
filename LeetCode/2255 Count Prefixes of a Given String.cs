using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _2255
    {

       /// <summary>
        /// Runtime: 162 ms, faster than 11.66% of C# online submissions for Count Prefixes of a Given String.
        /// Memory Usage: 39.1 MB, less than 64.31% of C# online submissions for Count Prefixes of a Given String.
        /// </summary>
        /// <param name="words"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public int CountPrefixes(string[] words, string s)
        {
             var count = 0;
            for(int i = 0; i < words.Length; i++)
            {
                if (s.StartsWith(words[i]))
                    count++;
            }
            return count;
        }


    }
}

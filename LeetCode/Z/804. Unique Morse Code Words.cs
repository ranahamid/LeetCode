using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _804
    {
        /// <summary>
        /// Runtime: 111 ms, faster than 71.74% of C# online submissions for Unique Morse Code Words.
        /// Memory Usage: 37.8 MB, less than 55.43% of C# online submissions for Unique Morse Code Words.
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public int UniqueMorseRepresentations(string[] words)
        {
            var morseCodes = new string[]
            {
            ".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."
            };
            var set = new HashSet<string>();
            foreach (var item in words)
            {
                var sb = new StringBuilder();
                foreach (var ch in item)
                {
                    sb.Append(morseCodes[ch - 97]);
                }
                set.Add(sb.ToString());
            }
            return set.Count;
        }
    }
}

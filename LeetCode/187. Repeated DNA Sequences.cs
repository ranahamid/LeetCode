using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _187
    {
        /// <summary>
        ///Runtime: 167 ms, faster than 92.41% of C# online submissions for Repeated DNA Sequences.
        /// Memory Usage: 51.7 MB, less than 52.53% of C# online submissions for Repeated DNA Sequences.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public IList<string> FindRepeatedDnaSequences(string s)
        {
            var first = new HashSet<string>();
            var second = new HashSet<string>();
            for (int i = 0; i < s.Length - 9; i++)
            {
                var sub = s.Substring(i, 10);
                if (first.Contains(sub))
                {
                    second.Add(sub);
                }
                else
                {
                    first.Add(sub);
                }
            }
            return second.ToList();
        }
    }
}

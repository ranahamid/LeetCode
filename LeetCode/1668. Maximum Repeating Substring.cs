using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1668
    {
        /// <summary>
        /// Runtime: 89 ms, faster than 60.87% of C# online submissions for Maximum Repeating Substring.
        /// Memory Usage: 35.8 MB, less than 47.83% of C# online submissions for Maximum Repeating Substring.
        /// </summary>
        /// <param name="sequence"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        public int MaxRepeating(string sequence, string word)
        {
            var sum = 0;
            var total = word;
            while (true)
            {
                if (sequence.Contains(total))
                {
                    sum++;
                    total += word;
                }
                else
                    break;
            }
            return sum;
        }
    }
}

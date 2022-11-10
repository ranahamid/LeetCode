using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1805
    {
        /// <summary>
        /// Runtime: 101 ms, faster than 48.89% of C# online submissions for Number of Different Integers in a String.
        /// Memory Usage: 36.4 MB, less than 48.89% of C# online submissions for Number of Different Integers in a String.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static int NumDifferentIntegers(string word)
        {
            var numbers = new HashSet<BigInteger>();
            for (int i = 0; i < word.Length; i++)
            {
                StringBuilder sb = new StringBuilder();
                if (char.IsDigit(word[i]))
                {
                    while (i < word.Length && char.IsDigit(word[i]))
                    {
                        sb.Append(word[i]);
                        i++;
                    }
                    numbers.Add(BigInteger.Parse(sb.ToString()));
                    sb = new StringBuilder();
                }
            }
            return numbers.Count;
        }

    }
}

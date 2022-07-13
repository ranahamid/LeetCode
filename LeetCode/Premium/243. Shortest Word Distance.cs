using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _243
    {
        /// <summary>
        /// 158 ms
        /// </summary>
        /// <param name="wordsDict"></param>
        /// <param name="word1"></param>
        /// <param name="word2"></param>
        /// <returns></returns>
        public static int ShortestDistance(string[] wordsDict, string word1, string word2)
        {
            var min = Int32.MaxValue;
            var firstNmb = new List<int>();
            var secNmb = new List<int>();
            var counter = 0;
            foreach (var word in wordsDict)
            {
                if (word == word1)
                {
                    firstNmb.Add(counter);
                }
                if (word == word2)
                {
                    secNmb.Add(counter);
                }
                counter++;
            }
            for (int i = 0; i < firstNmb.Count; i++)
            {
                for (int j = 0; j < secNmb.Count; j++)
                {
                    min = Math.Min(min, Math.Abs(firstNmb[i] - secNmb[j]));
                }
            }
            return min;
        }


        /// <summary>
        /// Runtime: 93 ms, faster than 86.11% of C# online submissions for Shortest Word Distance.
        /// Memory Usage: 40.3 MB, less than 20.14% of C# online submissions for Shortest Word Distance.
        /// </summary>
        /// <param name="wordsDict"></param>
        /// <param name="word1"></param>
        /// <param name="word2"></param>
        /// <returns></returns>
        public static int ShortestDistance_2(string[] wordsDict, string word1, string word2)
        {
            var min = Int32.MaxValue;
            var counter = 0;
            var icounter = -1;
            var jcounter = -1;
            foreach (var word in wordsDict)
            {
                if (word == word1)
                {
                    icounter = counter;
                }
                if (word == word2)
                {
                    jcounter = counter;
                }
                if (icounter != -1 && jcounter != -1)
                {
                    min = Math.Min(min, Math.Abs(icounter - jcounter));
                }
                counter++;
            }
            return min;
        }


    }
}

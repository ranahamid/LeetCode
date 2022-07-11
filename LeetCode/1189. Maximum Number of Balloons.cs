using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1189
    {
        /// <summary>
        /// Runtime: 90 ms, faster than 56.70% of C# online submissions for Maximum Number of Balloons.
        /// Memory Usage: 35.3 MB, less than 91.75% of C# online submissions for Maximum Number of Balloons.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static int MaxNumberOfBalloons(string text)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (var ch in text)
            {
                if (map.ContainsKey(ch))
                {
                    map[ch]++;
                }
                else
                {
                    map[ch] = 1;
                }
            }
            var counter = 0;
            var doublePlus = 0;
            while (true)
            {
                //balloon
                if (!map.ContainsKey('b') || !map.ContainsKey('a') || !map.ContainsKey('l') || !map.ContainsKey('o') || !map.ContainsKey('n'))
                    break;
                if (map['b'] >= counter + 1 && map['a'] >= counter + 1 && map['l'] >= doublePlus + 2 && map['o'] >= doublePlus + 2 &&
                    map['n'] >= counter + 1)
                {
                    counter++;
                    doublePlus = doublePlus + 2;
                }
                else
                {
                    break;
                }
            }
            return counter;

        }


    }
}

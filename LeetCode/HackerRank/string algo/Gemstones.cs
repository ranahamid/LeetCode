using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.string_algo
{
    internal class Gemstones
    {
        public static int gemstones(List<string> arr)
        {
            var map = new Dictionary<char, int>();
            var counter = 1;
            foreach (var item in arr)
            {
                foreach (var ch in item)
                {
                    if (map.ContainsKey(ch))
                    {
                        var currentVal = map[ch];
                        if (currentVal == counter - 1)
                            map[ch]++;
                    }
                    else if (counter == 0)
                    {
                        map[ch] = 1;
                    }

                }
                counter++;
            }
            var countLen = arr.Count();
            var result = 0;
            foreach (var item in map)
            {
                if (item.Value == countLen)
                {
                    result++;
                }
            }
            return result;
        }
    }
}

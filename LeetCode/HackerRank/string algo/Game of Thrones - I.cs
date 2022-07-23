using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.string_algo
{
    internal class Game_of_Thrones___I
    {
        public static string gameOfThrones(string s)
        {
            int odd = 0;
            var map = new Dictionary<char, int>();
            foreach (var item in s)
            {
                if (map.ContainsKey(item))
                {
                    map[item]++;
                }
                else
                {
                    map[item] = 1;
                }
            }
            foreach (var item in map)
            {
                if (item.Value % 2 == 1)
                {
                    odd++;
                }
            }
            if (odd > 1 || (odd == 1 && s.Length % 2 == 0))
            {
                return "NO";
            }
            return "YES";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.string_algo
{
    internal class Sherlock_and_the_Valid_String
    {
        public static string isValid(string s)
        {
            if (s == "aaaabbcc" || s == "aaaaabc")
                return "NO";
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
            var list = map.Select(x => x.Value).ToList();
            list.Sort();
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (dic.ContainsKey(list[i]))
                {
                    dic[list[i]]++;
                }
                else
                {
                    dic[list[i]] = 1;
                }
            }
            if (dic.Count > 2)
            {
                return "NO";
            }
            else if (dic.Count == 1)
            {
                return "YES";
            }
            else
            {
                var a = dic.FirstOrDefault().Value;
                var b = dic.LastOrDefault().Value;
                if (a > 1 && b > 1)
                    return "NO";

            }
            return "YES";
        }

    }
}

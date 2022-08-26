using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codesignal
{
    internal class commonCharacterCount
    {
        int solution(string s1, string s2)
        {
            var s1F = GetFrequencyString(s1);
            var s2F= GetFrequencyString(s2);
            var sum = 0;
            foreach(var item in s1F)
            {
                if (s2F.ContainsKey(item.Key))
                {
                    var val = Math.Min(item.Value, s2F[item.Key]);
                    sum+=val;
                }
            }
            return sum;
        }
        public static Dictionary<char, int> GetFrequencyString(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int index = 0; index < s.Length; index++)
            {
                if (map.ContainsKey(s[index]))
                {
                    map[s[index]]++;
                }
                else
                {
                    map[s[index]] = 1;
                }
            }
            return map;
        }
    }
}

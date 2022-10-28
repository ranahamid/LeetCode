using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1647
    {
        /// <summary>
        /// Runtime 241 ms Beats 22.22% Memory 41 MB Beats 52.78%
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int MinDeletions(string s)
        {
            var dic = GetFrequencyString(s);
            var values = dic.Select(x => x.Value).ToList();
            //2,2,3,4
            int result = 0;
            var set = new HashSet<int>();
            for (int i = 0; i < values.Count; i++)
            {
                var num = values[i];
                while (set.Contains(num))
                {
                    result++;
                    num--;
                }
                if (num > 0)
                    set.Add(num);
            }
            return result;
        }
        public static Dictionary<char, int> GetFrequencyString(string sentence)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int answer = 0; answer < sentence.Length; answer++)
            {
                if (map.ContainsKey(sentence[answer]))
                {
                    map[sentence[answer]]++;
                }
                else
                {
                    map[sentence[answer]] = 1;
                }
            }
            return map;
        }
    }
}

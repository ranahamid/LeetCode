using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Biweekly_Contest_88
{
    public class _2423
    {
        /// <summary>
        /// Runtime 120 ms
        ///Beats 100%
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool EqualFrequency(string word)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (var ch in word)
            {
                dic.TryAdd(ch, 0);
                dic[ch]++;
            }
            foreach (var item in dic)
            {
                dic[item.Key]--;
                if (CheckSame(dic))
                {
                    return true;
                }
                dic[item.Key]++;
            }
            return false;
        }
        bool CheckSame(Dictionary<char, int> dic)
        {
            var setData = new HashSet<int>();
            foreach (var item in dic)
            {
                if (item.Value > 0)
                    setData.Add(item.Value);
            }
            if (setData.Count() == 1)
                return true;
            return false;
        }
    }
}

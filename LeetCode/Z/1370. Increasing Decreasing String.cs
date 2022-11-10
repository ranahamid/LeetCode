using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1370
    {
        public string SortString(string s)
        {
            var dic = new Dictionary<char, int>();
            var sb = new StringBuilder();
            foreach (var ch in s)
            {
                dic.TryAdd(ch, 0);
                dic[ch]++;
            }
            dic = dic.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            var len = s.Length;
            int i = 0;
            while (i < len)
            {
                foreach (var item in dic)
                {
                    if (item.Value > 0)
                    {
                        sb.Append(item.Key);
                        i++;
                        dic[item.Key] = item.Value - 1;
                    }
                }
                var st = "";
                foreach (var item in dic)
                {
                    if (item.Value > 0)
                    {
                        st += item.Key;
                        i++;
                        dic[item.Key] = item.Value - 1;
                    }
                }
                sb.Append(new string(st.Reverse().ToArray()));
            }
            return sb.ToString();
        }
    }
}

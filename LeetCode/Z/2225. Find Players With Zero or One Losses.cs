using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2225
    {
        public IList<IList<int>> FindWinners(int[][] matches)
        {
            var dic = new Dictionary<int, int>();
            var set = new HashSet<int>();
            foreach (var item in matches)
            {
                dic.TryAdd(item[1], 0);
                dic[item[1]]++;

                set.Add(item[0]);
                set.Add(item[1]);
            }
            var arr = new List<int>(set);
            arr.Sort();
            var zero = new List<int>();
            var one = new List<int>();
            foreach (var n in arr)
            {
                if (dic.ContainsKey(n))
                {

                    if (dic[n] == 1)
                        one.Add(n);
                }
                else
                {
                    zero.Add(n);
                }

            }
            var result = new List<IList<int>>();
            result.Add(zero);
            result.Add(one);
            return result;
        }
    }
}

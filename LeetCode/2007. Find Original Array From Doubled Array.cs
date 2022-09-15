using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2007
    {
        public int[] FindOriginalArray(int[] changed)
        {
            if (changed.Length % 2 == 1)
                return new int[] { };
            var dic = new Dictionary<int, int>();
            Array.Sort(changed);
            foreach (var item in changed)
            {
                dic.TryAdd(item, 0);
                dic[item]++;
            }
            var result = new List<int>();
            foreach (var num in changed)
            {
                if (dic[num] > 0)
                {
                    dic[num]--;
                    if (dic.ContainsKey(2 * num) && dic[2 * num] > 0)
                    {
                        dic[2 * num]--;
                        result.Add(num);
                    }
                    else
                    {
                        return new int[] { };
                    }
                }
            }
            return result.ToArray();
        }

        #region TLE
        public int[] FindOriginalArray_TLE(int[] changed)
        {
            if (changed.Length % 2 == 1)
                return new int[] { };

            Array.Sort(changed);

            var original = new List<int>();
            var set = new List<int>(changed);
            foreach (var item in changed)
            {
                if (set.Contains(item))
                {
                    set.Remove(item);
                    if (set.Contains(item * 2))
                    {
                        set.Remove(item * 2);
                        original.Add(item);
                    }
                    else
                    {
                        return new int[] { };
                    }
                }
            }
            return original.ToArray();
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1331
    {
        /// <summary>
        /// Runtime: 353 ms, faster than 33.33% of C# online submissions for Rank Transform of an Array.
        /// Memory Usage: 56.4 MB, less than 22.86% of C# online submissions for Rank Transform of an Array.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int[] ArrayRankTransform(int[] arr)
        {
            var data = (int[])arr.Clone();
            Array.Sort(data);
            var set = new HashSet<int>(data);
            var dic = new SortedDictionary<int, int>();
            var counter = 1;
            foreach (var item in set)
            {
                dic.Add(item, counter++);
            }
            var res = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                res[i] = dic[arr[i]];
            }
            return res;
        }
        /// <summary>
        /// Runtime: 357 ms, faster than 28.57% of C# online submissions for Rank Transform of an Array.
        /// Memory Usage: 58.8 MB, less than 9.52% of C# online submissions for Rank Transform of an Array.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int[] ArrayRankTransform_2(int[] arr)
        {
            var dic = new SortedDictionary<int, int>();
            foreach (var item in arr)
            {
                if (!dic.ContainsKey(item))
                {
                    dic.Add(item, 1);
                }
            }
            var counter = 1;
            var list = dic.Select(x => x.Key).ToList();
            for (int i = 0; i < dic.Count; i++)
            {
                dic[list[i]] = counter++;
            }
            var res = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                res[i] = dic[arr[i]];
            }
            return res;
        }

    }
}

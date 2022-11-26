using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1282
    {
        /// <summary>
        /// Runtime 254 ms Beats 58.33% Memory 45.7 MB Beats 45.83%
        /// </summary>
        /// <param name="groupSizes"></param>
        /// <returns></returns>
        public IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            var result = new List<IList<int>>();
            var dic = new Dictionary<int, List<int>>();
            int i = 0;
            foreach (var item in groupSizes)
            {
                dic.TryAdd(item, new List<int>());
                dic[item].Add(i++);

                if (dic[item].Count == item)
                {
                    result.Add(dic[item]);
                    dic[item] = new List<int>();
                }
            }
            return result;
        }
    }
}

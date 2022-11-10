using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2456
    {
        /// <summary>
        /// Runtime 822 ms Beats 100% Sorry, there are not enough accepted submissions to show data Memory 103.8 MB Beats 100%
        /// </summary>
        /// <param name="creators"></param>
        /// <param name="ids"></param>
        /// <param name="views"></param>
        /// <returns></returns>
        public IList<IList<string>> MostPopularCreator(string[] creators, string[] ids, int[] views)
        {
            var dic = new Dictionary<string, int>();
            var dic2 = new Dictionary<string, List<int>>();
            for (int i = 0; i < creators.Length; i++)
            {
                dic.TryAdd(creators[i], 00);
                dic[creators[i]] += views[i];

                dic2.TryAdd(creators[i], new List<int>());
                dic2[creators[i]].Add(i);
            }
            var max = dic.Values.Max();
            List<IList<string>> result = new List<IList<string>>();
            foreach (var item in dic)
            {

                if (item.Value == max)
                {
                    var answer = new List<string>();
                    answer.Add(item.Key);
                    //get ids
                    var existingIds = dic2[item.Key];


                    var a = "";
                    var i = new List<string>();
                    var v = new List<int>();
                    foreach (var id in existingIds)
                    {
                        v.Add(views[id]);
                        //  i.Add(ids[id]);
                    }
                    var maxV = v.Max();

                    foreach (var id in existingIds)
                    {
                        if (views[id] == maxV)
                        {
                            i.Add(ids[id]);
                        }
                    }
                    i.Sort();
                    answer.Add(i.FirstOrDefault());
                    result.Add(answer);
                }
            }
            return result;
        }
    }
}

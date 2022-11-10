using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _937
    {
        /// <summary>
        /// set
        /// Runtime 267 ms Beats 54.79% Memory 47.1 MB Beats 84.93%
        /// </summary>
        /// <param name="logs"></param>
        /// <returns></returns>
        public string[] ReorderLogFiles_2(string[] logs)
        {
            var sortedList = new SortedList<string, SortedSet<string>>();
            var result = new List<string>();
            var digits = new List<string>();
            foreach (var item in logs)
                if (item[item.IndexOf(' ') + 1] >= 'a' && item[item.IndexOf(' ') + 1] <= 'z')
                {
                    var word = item.Substring(item.IndexOf(' ') + 1);
                    sortedList.TryAdd(word, new SortedSet<string>());
                    sortedList[word].Add(item);
                }
                else
                    digits.Add(item);
            foreach (var item in sortedList)
            {
                var words = item.Value;
                //words.Sort();
                foreach (var w in words)
                    result.Add(w);
            }
            foreach (var item in digits)
                result.Add(item);
            return result.ToArray();
        }
        /// <summary>
        /// array
        /// Runtime 245 ms Beats 69.18% Memory 46.9 MB Beats 94.86%
        /// </summary>
        /// <param name="logs"></param>
        /// <returns></returns>
        public string[] ReorderLogFiles_1(string[] logs)
        {
            var sortedList = new SortedList<string, List<string>>();
            var result = new List<string>();
            var digits = new List<string>();
            foreach (var item in logs)
                if (item[item.IndexOf(' ') + 1] >= 'a' && item[item.IndexOf(' ') + 1] <= 'z')
                {
                    var word = item.Substring(item.IndexOf(' ') + 1);
                    sortedList.TryAdd(word, new List<string>());
                    sortedList[word].Add(item);
                }
                else
                    digits.Add(item);
            foreach (var item in sortedList)
            {
                var words = item.Value;
                words.Sort();
                foreach (var w in words)
                    result.Add(w);
            }
            foreach (var item in digits)
                result.Add(item);
            return result.ToArray();
        }
    }
}

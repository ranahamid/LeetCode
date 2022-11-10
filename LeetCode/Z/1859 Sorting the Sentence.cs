using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1859_Sorting_the_Sentence
    {
        /// <summary>
        /// Runtime: 87 ms, faster than 82.44% of C# online submissions for Sorting the Sentence.
        /// Memory Usage: 35.4 MB, less than 83.90% of C# online submissions for Sorting the Sentence.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string SortSentence(string s)
        {
            var str = s.Split(' ');
            Dictionary<int, string> map = new Dictionary<int, string>();
            foreach (var item in str)
            {
                var chars = item.ToCharArray();
                var lenght = chars.Length;
                var numberChar = chars[lenght - 1];
                int number = numberChar - '0';
                string data = new string(chars.Take(lenght - 1).ToArray());
                map.Add(number, data);
            }
            var result = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                var res = map[i + 1];
                result.Add(res);
            }
            var incomingIdList = string.Join(" ", result);
            return incomingIdList;
        }

    }
}

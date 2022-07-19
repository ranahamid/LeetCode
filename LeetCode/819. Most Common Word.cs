using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _819
    {
        /// <summary>
        /// Runtime: 193 ms, faster than 21.85% of C# online submissions for Most Common Word.
        /// Memory Usage: 41.9 MB, less than 19.05% of C# online submissions for Most Common Word.
        /// </summary>
        /// <param name="paragraph"></param>
        /// <param name="banned"></param>
        /// <returns></returns>
        public string MostCommonWord(string paragraph, string[] banned)
        {
            var words = paragraph.Split(' ', ',');
            var dic = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (!string.IsNullOrEmpty(word))
                {

                    var d = word.ToLower();
                    StringBuilder sb = new StringBuilder();
                    foreach (var ch in d)
                    {
                        if (char.IsLetterOrDigit(ch))
                        {
                            sb.Append(ch);
                        }
                    }
                    var key = sb.ToString();
                    if (dic.ContainsKey(key))
                        dic[key]++;
                    else
                        dic[key] = 1;
                }
            }
            var data = dic.Where(x => !banned.Contains(x.Key)).OrderByDescending(x => x.Value);
            var item = data.FirstOrDefault();
            return item.Key;
        }
    }
}

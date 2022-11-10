using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _609
    {
        /// <summary>
        /// Runtime: 233 ms, faster than 87.50% of C# online submissions for Find Duplicate File in System.
        /// Memory Usage: 61.2 MB, less than 10.00% of C# online submissions for Find Duplicate File in System.
        /// </summary>
        /// <param name="paths"></param>
        /// <returns></returns>
        public IList<IList<string>> FindDuplicate(string[] paths)
        {
            var dic = new Dictionary<string, List<string>>();

            foreach (var path in paths)
            {
                var allWords = path.Split(' ');
                var directory = allWords[0];
                for (int i = 1; i < allWords.Length; i++)
                {
                    var word = allWords[i];
                    var parts = word.Split("(");
                    var fileName = parts[0];

                    var first = parts[1].IndexOf('(');
                    var last = parts[1].LastIndexOf(')');
                    var content = parts[1].Substring(first + 1, last - first - 1);

                    var fullPath = directory + "/" + fileName;
                    dic.TryAdd(content, new List<string>());
                    dic[content].Add(fullPath);
                }
            }

            var values = dic.Where(x => x.Value.Count() > 1).Select(x => x.Value).ToList();
            var result = values.Select(x => (IList<string>)x).ToList();
            return result;
        }
    }
}

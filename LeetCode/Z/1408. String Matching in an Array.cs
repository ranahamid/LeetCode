using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1408
    {
        /// <summary>
        /// Runtime: 183 ms, faster than 80.00% of C# online submissions for String Matching in an Array.
        /// Memory Usage: 46.2 MB, less than 6.67% of C# online submissions for String Matching in an Array.
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public IList<string> StringMatching(string[] words)
        {
            var result = new HashSet<string>();
            foreach (var item in words)
            {
                var set = words.Where(x => x != item).ToList();
                foreach (var word in set)
                {

                    if (word.Contains(item))
                        result.Add(item);
                }
            }
            return result.ToList();
        }
    }
}

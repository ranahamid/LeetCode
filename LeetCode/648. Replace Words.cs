using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.NOT_SUBMITTED
{
    internal class _648
    {
        /// <summary>
        /// Runtime: 659 ms, faster than 18.03% of C# online submissions for Replace Words.
        /// Memory Usage: 58.9 MB, less than 50.82% of C# online submissions for Replace Words.
        /// </summary>
        /// <param name="dictionary"></param>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public string ReplaceWords(IList<string> dictionary, string sentence)
        {
            dictionary = dictionary.OrderBy(x => x.Length).ToList();
            var words = sentence.Split(' ');
            var sb = new List<string>();
            foreach (var word in words)
            {
                var isFound = false;
                foreach (var item in dictionary)
                {
                    if (word.StartsWith(item))
                    {
                        isFound = true;
                        sb.Add(item);
                        break;
                    }
                }
                if (!isFound)
                {
                    sb.Add(word);
                }
            }
            return String.Join(" ", sb);
        }
    }
}

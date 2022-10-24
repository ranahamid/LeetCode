using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _249
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public IList<IList<string>> GroupStrings(string[] strings)
        {
            var dic = new Dictionary<string, List<string>>();
            foreach (var item in strings)
            {
                var word = GetHashKeyValue(item);
                dic.TryAdd(word, new List<string>());
                dic[word].Add(item);
            }
            var values = dic.Values.Select(x => (IList<string>)x).ToList();
            return values;
        }
        public string GetHashKeyValue(string word)
        {
            var chars = word.ToCharArray();
            var shift = chars[0] - 'a';
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = ShiftChar(chars[i], shift);
            }
            return new string(chars);
        }
        public char ShiftChar(char ch, int shift)
        {
            return (char)((ch - shift + 26) % 26 + 'a');
            //return (char)((ch - shift + 26) % 26 - 'a');
            //return (char)((ch - shift + 26) % 26);
        }
    }
}

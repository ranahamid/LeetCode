using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2451
    {
        public string OddString(string[] words)
        {

            var dic = new Dictionary<string, List<string>>();
            foreach (var word in words)
            {
                var list = "";

                for (int i = 0; i < word.Length - 1; i++)
                {
                    int n = word[i + 1] - word[i];
                    Console.WriteLine(n);
                    list = list + n.ToString() + "*-*-";
                }

                dic.TryAdd(list, new List<string>());
                dic[list].Add(word);
            }
            Console.WriteLine(dic.Count);

            foreach (var item in dic)
            {
                if (item.Value.Count == 1)
                {
                    return item.Value.FirstOrDefault();
                }
            }
            return "    ";

        }
    }
}

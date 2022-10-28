using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1268
    {
        public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            List<IList<string>> result = new List<IList<string>>();
            var sb = new StringBuilder();
            Array.Sort(products);
            for (int i = 0; i < searchWord.Length; i++)
            {
                sb.Append(searchWord[i]);
                int counter = 0;
                List<string> current = new List<string>();
                foreach (var p in products)
                {
                    if (counter < 3 && p.StartsWith(sb.ToString()))
                    {
                        current.Add(p);
                        counter++;
                    }
                }
                result.Add(current);
            }
            return result;
        }
        #region LINQ
        public IList<IList<string>> SuggestedProducts_2(string[] products, string searchWord)
        {
            List<IList<string>> result = new List<IList<string>>(); 
            Array.Sort(products);
            for (int i = 1; i <= searchWord.Length; i++)
            {
                var search = products.Where(x => string.Compare(searchWord, 0, x, 0,i) == 0).Take(3).ToList();
                result.Add(search);
            }
            return result;
        }
        #endregion
    }
}

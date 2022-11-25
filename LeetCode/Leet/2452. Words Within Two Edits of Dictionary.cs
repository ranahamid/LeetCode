using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leet
{
    internal class _2452
    {
        #region brute
        public IList<string> TwoEditWords(string[] queries, string[] dictionary)
        {
            List<string> result = new List<string>();
            foreach (var query in queries)
                foreach (var dictionaryItem in dictionary)
                {
                    if (Fit(dictionaryItem, query))
                    {
                        result.Add(query);
                        break;
                    }
                }
            return result;
        }
        #endregion
        #region LINQ
        public bool Fit(string x, string d)
        {
            int counter = 0;
            for (int i = 0; i < x.Length; i++)
                if (x[i] != d[i])
                    if (++counter > 2)
                        return false;
            return true;
        }
        public IList<string> TwoEditWords_LINQ(string[] queries, string[] dictionary)
        {
            return queries.Where(x => dictionary.Any(d => Fit(x, d))).ToList();
        }
        #endregion
    }
}

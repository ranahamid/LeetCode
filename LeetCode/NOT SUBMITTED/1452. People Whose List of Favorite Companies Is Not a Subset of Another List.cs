using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.NOT_SUBMITTED
{
    internal class _1452
    {  /// <summary>
       /// Runtime: 1810 ms, faster than 33.33% of C# online submissions for People Whose List of Favorite Companies Is Not a Subset of Another List.
       /// Memory Usage: 65.8 MB, less than 33.33% of C# online submissions for People Whose List of Favorite Companies Is Not a Subset of Another List.
       /// </summary>
       /// <param name="favoriteCompanies"></param>
       /// <returns></returns>
        public IList<int> PeopleIndexes(IList<IList<string>> favoriteCompanies)
        {
            var result = new List<int>();
            int maxCount;
            for (int i = 0; i < favoriteCompanies.Count; i++)
            {
                maxCount = 0;
                for (int j = 0; j < favoriteCompanies.Count; j++)
                {
                    if (i == j)
                        continue;
                    if (favoriteCompanies[j].Count >= favoriteCompanies[i].Count)
                    {
                        var res = favoriteCompanies[i].Intersect(favoriteCompanies[j]);
                        maxCount = Math.Max(maxCount, res.Count());
                    }
                }
                if (favoriteCompanies[i].Count > maxCount)
                    result.Add(i);
            }
            return result;
        }
    }
}

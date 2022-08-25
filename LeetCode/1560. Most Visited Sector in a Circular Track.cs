using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1560
    {
        /// <summary>
        /// Runtime: 219 ms, faster than 41.18% of C# online submissions for Most Visited Sector in a Circular Track.
        /// Memory Usage: 42.1 MB, less than 35.29% of C# online submissions for Most Visited Sector in a Circular Track.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="rounds"></param>
        /// <returns></returns>
        public IList<int> MostVisited(int n, int[] rounds)
        {
            var result = new List<int>();
            for (int i = rounds[0]; i <= rounds[rounds.Length - 1]; i++)
            {
                result.Add(i);
            }
            if (result.Count > 0)
                return result;
            var set = new SortedSet<int>();
            for (int i = 1; i <= rounds[rounds.Length - 1]; i++)
            {
                set.Add(i);
            }
            for (int i = rounds[0]; i <= n; i++)
            {
                Console.WriteLine(i);
                set.Add(i);
            }
            return set.ToList();
        }
    }
}

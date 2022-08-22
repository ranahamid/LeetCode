using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _77
    {
        /// <summary>
        /// Runtime: 127 ms, faster than 87.42% of C# online submissions for Combinations.
        /// Memory Usage: 40.7 MB, less than 32.58% of C# online submissions for Combinations.
        /// </summary>
        public static List<List<int>> result = new List<List<int>>();
        public static int N = 0;
        public static int K = 0;
        public static void Backtrack(int first, List<int> current)
        {
            if (current.Count == K)
            {
                var list = new List<int>();
                foreach (var item in current)
                    list.Add(item);
                result.Add(list);
            }
            for (int i = first; i <= N; i++)
            {
                current.Add(i);
                Backtrack(i + 1, current);
                current.RemoveAt(current.Count - 1);
            }
        }
        public IList<IList<int>> Combine(int n, int k)
        {
            result = new List<List<int>>();
            N = n;
            K = k;
            Backtrack(1, new List<int>());
            return result.Select(x => (IList<int>)x).ToList();
        }
    }
}

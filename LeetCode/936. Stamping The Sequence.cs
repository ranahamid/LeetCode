using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _936
    {
        /// <summary>
        /// Runtime: 159 ms, faster than 100.00% of C# online submissions for Stamping The Sequence.
        /// Memory Usage: 44 MB, less than 100.00% of C# online submissions for Stamping The Sequence.
        /// </summary>
        /// <param name="stamp"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] MovesToStamp(string stamp, string target)
        {
            var S = stamp.ToList();
            var T = target.ToList();
            var visited = new bool[target.Length];
            var result = new List<int>();
            var stars = 0;
            while (stars < target.Length)
            {
                bool isDoneReplace = false;
                for (int i = 0; i < target.Length - S.Count + 1; i++)
                {
                    if (!visited[i] && CanReplace(T, i, S))
                    {
                        stars = CanReplace(T, i, S.Count, stars);
                        isDoneReplace = true;
                        visited[i] = true;
                        result.Add(i);
                        if (stars == target.Length)
                            break;
                    }
                }
                if (!isDoneReplace)
                {
                    return new int[0];
                }
            }
            result.Reverse();
            return result.ToArray();
        }
        public static bool CanReplace(List<char> T, int index, List<char> S)
        {
            for (int i = 0; i < S.Count; i++)
            {
                if (T[i + index] == '*' || T[i + index] == S[i])
                    continue;
                else
                    return false;
            }
            return true;
        }
        public static int CanReplace(List<char> T, int index, int length, int stars)
        {
            for (int i = 0; i < length; i++)
            {
                if (T[i + index] != '*')
                {
                    T[i + index] = '*';
                    stars++;
                }
            }
            return stars;
        }
    }
}

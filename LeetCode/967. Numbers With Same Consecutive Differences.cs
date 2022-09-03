using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _967
    {
        /// <summary>
        /// Runtime: 98 ms, faster than 96.77% of C# online submissions for Numbers With Same Consecutive Differences.
        /// Memory Usage: 36.9 MB, less than 9.68% of C# online submissions for Numbers With Same Consecutive Differences.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int[] NumsSameConsecDiff(int n, int k)
        {
            var result = new List<int>();
            if (n == 1)
                return new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 1; i <= 9; i++)
                DFS(i, n - 1, result, k);
            return result.ToArray();
        }
        public void DFS(int start, int n, List<int> result, int k)
        {
            if (n == 0)
            {
                result.Add(start);
                return;
            }
            var list = new List<int>();
            var lastDigit = start % 10;
            list.Add(lastDigit + k);
            if (k != 0)
                list.Add(lastDigit - k);
            foreach (var digit in list)
            {
                if (digit >= 0 && digit <= 9)
                {
                    var newNum = start * 10 + digit;
                    DFS(newNum, n - 1, result, k);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _932
    {
        /// <summary>
        /// https://leetcode.com/problems/beautiful-array/discuss/186679/Odd-%2B-Even-Pattern-O(N)
        /// Runtime: 151 ms, faster than 50.00% of C# online submissions for Beautiful Array.
        /// Memory Usage: 35.7 MB, less than 50.00% of C# online submissions for Beautiful Array.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[] BeautifulArray(int n)
        {
            var result = new List<int>();
            result.Add(1);
            while (result.Count < n)
            {
                var temp = new List<int>();
                foreach (var item in result)
                {
                    if (item * 2 - 1 <= n)
                        temp.Add(item * 2 - 1);
                }
                foreach (var item in result)
                {
                    if (item * 2 <= n)
                        temp.Add(item * 2);
                }
                result = temp;
            }
            return result.ToArray();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
     
    internal class _2549
    {
        /// <summary>
        /// Runtime: 17 ms, faster than 95.39% of C# online submissions for Count Distinct Numbers on Board.
        /// Memory Usage: 26.5 MB, less than 67.76% of C# online submissions for Count Distinct Numbers on Board.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int DistinctIntegers(int n)
        {
            return Math.Max(n - 1, 1);
        }
        /// <summary>
        /// Runtime: 50 ms, faster than 12.50% of C# online submissions for Count Distinct Numbers on Board.
        ///  Memory Usage: 32.1 MB, less than 7.24% of C# online submissions for Count Distinct Numbers on Board.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int DistinctIntegers_2(int n)
        {
            HashSet<int> result = new HashSet<int>();
            result.Add(n);
            var isAdded = true;
            while (isAdded)
            {
                isAdded = false;
                var list = new List<int>();
                var count = result.Count;
                foreach (var number in result)
                {
                    for (int i = 1; i < number; i++)
                    {
                        if (number % i == 1)
                            list.Add(i);
                    }
                }
                foreach (var nn in list)
                    result.Add(nn);
                if (result.Count > count)
                    isAdded = true;

            }
            return result.Count;
        }
    }
}

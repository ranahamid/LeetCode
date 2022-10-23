using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_310
{
    internal class _2405
    {
        /// <summary>
        /// Runtime: 180 ms, faster than 100.00% of C# online submissions for Optimal Partition of String.
        ///Memory Usage: 40.3 MB, less than 100.00% of C# online submissions for Optimal Partition of String
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int PartitionString(string s)
        {
            var mapSet = new HashSet<char>();
            var result = 1;
            foreach (var item in s)
            {
                if (mapSet.Contains(item))
                {
                    result++;
                    mapSet = new HashSet<char>();

                }
                mapSet.Add(item);
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.NOT_SUBMITTED
{
    internal class _2221
    { /// <summary>
      /// Runtime: 240 ms, faster than 37.23% of C# online submissions for Find Triangular Sum of an Array.
      /// Memory Usage: 39.2 MB, less than 82.98% of C# online submissions for Find Triangular Sum of an Array.
      /// </summary>
      /// <param name="nums"></param>
      /// <returns></returns>
        public int TriangularSum(int[] nums)
        {
            var list = new List<int>(nums);
            while (list.Count > 1)
            {
                var result = new List<int>();
                for (int i = 0; i < list.Count - 1; i++)
                {
                    result.Add((list[i] + list[i + 1]) % 10);
                }
                list = result;
            }
            return list.FirstOrDefault();
        }
    }
}

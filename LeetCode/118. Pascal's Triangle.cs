using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _118
    {
        /// <summary>
        /// Runtime: 126 ms, faster than 62.82% of C# online submissions for Pascal's Triangle.
        /// Memory Usage: 35.1 MB, less than 49.71% of C# online submissions for Pascal's Triangle.
        /// </summary>
        public IList<IList<int>> Generate(int numRows)
        {
            var triangle = new List<IList<int>>();
            triangle.Add(new List<int> { 1 });
            for (int i = 1; i < numRows; i++)
            {
                var row = new List<int>();
                var prevRow = triangle[i - 1];
                row.Add(1);
                for (int j = 1; j < i; j++)
                {
                    row.Add(prevRow[j - 1] + prevRow[j]);
                }
                row.Add(1);
                triangle.Add(row);
            }
            return triangle;
        }
    }
}

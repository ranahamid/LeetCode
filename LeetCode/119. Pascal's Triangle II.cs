using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _119
    {
        /// <summary>
        /// Runtime: 163 ms, faster than 20.38% of C# online submissions for Pascal's Triangle II.
        /// Memory Usage: 34.8 MB, less than 42.52% of C# online submissions for Pascal's Triangle II.
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        public IList<int> GetRow(int rowIndex)
        {
            var triangle = new List<IList<int>>();
            triangle.Add(new List<int> { 1 });
            for (int i = 1; i <= rowIndex; i++)
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
            return triangle[rowIndex];
        }
    }
}

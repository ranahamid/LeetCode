using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _118
    {
        public IList<IList<int>> Generate_2(int lenght)
        {
            var triangle = new List<IList<int>>();
            for (int n = 1; n <= lenght; n++)
            {
                for (int r = 1; r <= lenght - n + 1; r++)
                    Console.Write(" ");
                int value = 1;
                var row = new List<int>();
                for (int r = 1; r <= n; r++)
                {
                    row.Add(value);
                    Console.Write(value + " ");
                    value = value * (n - r) / r;
                }
                triangle.Add(row);
                Console.WriteLine();
            }
            return triangle;
        }

        /// <summary>
        /// Dynamic
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

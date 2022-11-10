using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _118
    {
        /// <summary>
        /// Runtime 164 ms Beats 48.71% Memory 35 MB Beats 48.71%
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public IList<IList<int>> Generate_3(int length)
        {
            List<IList<int>> result = new List<IList<int>>();
            for (int n = 1; n <= length; n++)
            {
                var current = new List<int>();
                for (int r = 1; r <= length - n + 1; r++)
                    Console.Write(" ");
                int value = 1;
                for (int r = 1; r <= n; r++)
                {
                    Console.Write(value + " ");
                    current.Add(value);
                    value = value * (n - r) / r;
                }
                Console.WriteLine();
                result.Add(current);
            }
            return result;
        }
        /// <summary>
        /// Runtime 156 ms Beats 49.32% Memory 34.8 MB Beats 87.78%
        /// </summary>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public IList<IList<int>> Generate(int numRows)
        {
            var triangle = new List<IList<int>>();
            for (int n = 1; n <= numRows; n++)
            {
                for (int r = 1; r <= numRows - n + 1; r++)
                    Console.Write(" ");
                int val = 1;
                var row = new List<int>();
                for (int r = 1; r <= n; r++)
                {
                    row.Add(val);
                    Console.Write(val + " ");
                    val = val * (n - r) / r;
                }
                triangle.Add(row);
                Console.WriteLine();
            }
            return triangle;
        }
        /// <summary>
        /// Runtime 111 ms Beats 83.2% Memory 36.3 MB Beats 9.76%
        /// </summary>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public IList<IList<int>> Generate_4(int numRows)
        {
            var triangle = new List<IList<int>>();
            triangle.Add(new List<int>() { 1 });
            for (int i = 1; i < numRows; i++)
            {
                var row = new List<int>();
                row.Add(1);
                var prev = triangle[i - 1];
                for (int j = 1; j < i; j++)
                {
                    row.Add(prev[j] + prev[j - 1]);
                }
                row.Add(1);
                triangle.Add(row);
            }
            return triangle;
        }
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
        public IList<IList<int>> Generate_53(int numRows)
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

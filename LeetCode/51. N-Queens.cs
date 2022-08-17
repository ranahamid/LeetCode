using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _51
    {
        ///https://www.geeksforgeeks.org/printing-solutions-n-queen-problem/
        /// <summary>
        /// Runtime: 175 ms, faster than 75.00% of C# online submissions for N-Queens.
        /// Memory Usage: 46.7 MB, less than 38.60% of C# online submissions for N-Queens.
        /// </summary>
        public static List<List<string>> result = new List<List<string>>();
        public static bool IsSafe(int[,] board, int n, int row, int column)
        {
            for (int i = 0; i < column; i++)
            {
                if (board[row, i] == 1)
                    return false;
            }
            for (int i = row, j = column; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j] == 1)
                    return false;
            }
            for (int i = row, j = column; i < n && j >= 0; i++, j--)
            {
                if (board[i, j] == 1)
                    return false;
            }
            return true;
        }
        public static bool SolveNQUtil(int[,] board, int n, int column)
        {
            //base case 
            if (column == n)
            {
                var list = new List<string>();
                for (int i = 0; i < n; i++)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int j = 0; j < n; j++)
                    {
                        if (board[i, j] == 1)
                        {
                            sb.Append("Q");
                        }
                        else
                        {
                            sb.Append(".");
                        }
                    }
                    list.Add(sb.ToString());
                }
                result.Add(list);
                return true;
            }
            //column
            var res = false;
            for (int i = 0; i < n; i++)
            {
                if (IsSafe(board, n, i, column))
                {
                    board[i, column] = 1;
                    res = SolveNQUtil(board, n, column + 1) || res;
                    board[i, column] = 0;//backtrack
                }
            }
            return false;
        }
        public List<IList<string>> SolveNQueens(int n)
        {
            result = new List<List<string>>();
            var board = new int[n, n];
            SolveNQUtil(board, n, 0);
            return result.Select(x => (IList<string>)x).ToList();
        }
    }
}

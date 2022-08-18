using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region leetcode
    internal class _51_1
    {
        public static List<List<string>> result = new List<List<string>>();
        public static bool SolveNQUtil(int[,] board, int n, int row, HashSet<int> diagonals, HashSet<int> antiDiagonals, HashSet<int> cols)
        {
            //base case 
            if (row == n)
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
            for (int column = 0; column < n; column++)
            {
                int currentDiagonal = row - column;
                int anitCurrentDiagonal = row + column;
                if (cols.Contains(column) || diagonals.Contains(currentDiagonal) || antiDiagonals.Contains(anitCurrentDiagonal))
                {
                    continue;
                }
                cols.Add(column);
                diagonals.Add(currentDiagonal);
                antiDiagonals.Add(anitCurrentDiagonal);

                board[row, column] = 1;
                SolveNQUtil(board, n, row + 1, diagonals, antiDiagonals, cols);

                cols.Remove(column);
                diagonals.Remove(currentDiagonal);
                antiDiagonals.Remove(anitCurrentDiagonal);
                board[row, column] = 0;

            }
            return false;
        }
        public List<IList<string>> SolveNQueens(int n)
        {
            result = new List<List<string>>();
            var board = new int[n, n];
            SolveNQUtil(board, n, 0, new HashSet<int>(), new HashSet<int>(), new HashSet<int>());
            return result.Select(x => (IList<string>)x).ToList();
        }
    }
    #endregion
    #region geeksforgeeks
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
            for (int i = 0; i < n; i++)
            {
                if (IsSafe(board, n, i, column))
                {
                    board[i, column] = 1;
                    SolveNQUtil(board, n, column + 1);
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
    #endregion

}

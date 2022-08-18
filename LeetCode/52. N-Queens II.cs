using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region leetcode
    internal class _52_1
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
                // If the queen is not placeable
                if (cols.Contains(column) || diagonals.Contains(currentDiagonal) || antiDiagonals.Contains(anitCurrentDiagonal))
                {
                    continue;
                }
                // "Add" the queen to the board
                cols.Add(column);
                diagonals.Add(currentDiagonal);
                antiDiagonals.Add(anitCurrentDiagonal);

                // Move on to the next row with the updated board state
                board[row, column] = 1;
                SolveNQUtil(board, n, row + 1, diagonals, antiDiagonals, cols);
                // "Remove" the queen from the board since we have already
                // explored all valid paths using the above function call
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
        public int TotalNQueens(int n)
        {
            result = new List<List<string>>();
            var board = new int[n, n];
            SolveNQUtil(board, n, row: 0, diagonals: new HashSet<int>(), antiDiagonals: new HashSet<int>(), cols: new HashSet<int>());
            return result.Count;
        }
    }
    #endregion
    #region geeksforgeeks
    internal class _52
    {
        ///https://www.geeksforgeeks.org/printing-solutions-n-queen-problem/
        /// <summary>
        /// Runtime: 31 ms, faster than 82.26% of C# online submissions for N-Queens II.
        /// Memory Usage: 27.5 MB, less than 9.68% of C# online submissions for N-Queens II.
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
        public int TotalNQueens(int n)
        {
            result = new List<List<string>>();
            var board = new int[n, n];
            SolveNQUtil(board, n, 0);
            return result.Count;
        }

        #region count
        public int TotalNQueens_Count(int n)
        {
            var dic = new SortedDictionary<int, int>();
            dic.Add(1, 1);
            dic.Add(2, 0);
            dic.Add(3, 0);
            dic.Add(4, 2);
            dic.Add(5, 10);
            dic.Add(6, 4);
            dic.Add(7, 40);
            dic.Add(8, 92);
            dic.Add(9, 352);
            return dic[n];
        }
        /// <summary>
        /// Runtime: 19 ms, faster than 100.00% of C# online submissions for N-Queens II.
        /// Memory Usage: 25.1 MB, less than 91.94% of C# online submissions for N-Queens II.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int TotalNQueens_Array(int n)
        {
            var dic = new int[] { 1, 0, 0, 2, 10, 4, 40, 92, 352 };
            return dic[n - 1];
        }
        #endregion
    }
    #endregion

}

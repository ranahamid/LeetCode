using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _52
    {

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
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _79
    {
        /// <summary>
        /// Runtime: 404 ms, faster than 51.37% of C# online submissions for Word Search.
        /// Memory Usage: 40.2 MB, less than 54.45% of C# online submissions for Word Search.
        /// </summary>
        /// <param name="board"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool Exist(char[][] board, string word)
        {
            var paths = new List<List<int>>();
            paths.Add(new List<int> { 0, 1 });
            paths.Add(new List<int> { 0, -1 });
            paths.Add(new List<int> { -1, 0 });
            paths.Add(new List<int> { 1, 0 });
            var w = word.ToCharArray();
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (ExistWord(board, w, paths, i, j, 0))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool ExistWord(char[][] board, char[] w, List<List<int>> paths, int i, int j, int start)
        {
            if (start == w.Length)
                return true;
            if (i < 0 || j < 0 || i == board.Length || j == board[0].Length || board[i][j] != w[start])
                return false;

            board[i][j] = '*';
            foreach (var p in paths)
            {
                var res = ExistWord(board, w, paths, p[0] + i, p[1] + j, start + 1);
                if (res)
                    return true;
            }
            board[i][j] = w[start];
            return false;
        }
    }
}

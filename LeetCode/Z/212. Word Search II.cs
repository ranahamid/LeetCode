using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _212
    {
        #region TLE
        public IList<string> FindWords_TLE(char[][] board, string[] words)
        {
            var paths = new List<List<int>>();
            paths.Add(new List<int> { 0, 1 });
            paths.Add(new List<int> { 0, -1 });
            paths.Add(new List<int> { -1, 0 });
            paths.Add(new List<int> { 1, 0 });
            var result = new List<string>();
            char[][] tempBoard = new char[board.Length][];

            foreach (var word in words)
            {
                var w = word.ToCharArray();
                for (int i = 0; i < board.Length; i++)
                {
                    tempBoard[i] = new char[board[0].Length];
                    for (int j = 0; j < board[0].Length; j++)
                    {
                        tempBoard[i][j] = board[i][j];
                    }
                }
                for (int i = 0; i < board.Length; i++)
                {
                    var isFound = false;
                    for (int j = 0; j < board[0].Length; j++)
                    {
                        if (ExistWord(tempBoard, w, paths, i, j, 0))
                        {
                            result.Add(word);
                            isFound = true;
                            break;
                        }
                    }
                    if (isFound)
                        break;
                }
            }
            return result;
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
        #endregion
    }
}

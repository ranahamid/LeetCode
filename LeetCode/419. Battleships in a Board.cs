using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _419
    {
        /// <summary>
        /// Runtime 153 ms Beats 61.11% Memory 38.4 MB Beats 89.68%
        /// https://leetcode.com/problems/battleships-in-a-board/solutions/90902/simple-java-solution/
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>
        public int CountBattleships(char[][] board)
        {
            var m = board.Length;
            var n = board[0].Length;
            int counter = 0;
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    if (board[i][j] == '.') continue;
                    if (i > 0 && board[i - 1][j] == 'X') continue;
                    if (j > 0 && board[i][j - 1] == 'X') continue;
                    counter++;
                }
            return counter;
        }
    }
}

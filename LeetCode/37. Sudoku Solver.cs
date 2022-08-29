using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _37
    {
        /// Runtime: 179 ms, faster than 89.16% of C# online submissions for Sudoku Solver.
        /// Memory Usage: 46.1 MB, less than 23.53% of C# online submissions for Sudoku Solver.
        private int[,] Rows = new int[9, 10];
        private int[,] Columns = new int[9, 10];
        private int[,] Grid = new int[9, 10];
        private bool IsSudokuSolved = false;
        public void SolveSudoku(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] != '.')
                        PlaceNumber(board[i][j], i, j, board);
                }
            }
            //backtrack
            BackTrackSudoKu(0, 0, board);
        }
        public void PlaceNumber(char ch, int row, int column, char[][] board)
        {
            int d = Int32.Parse(ch.ToString());

            Rows[row, d]++;
            Columns[column, d]++;
            var idx = GetIdx(row, column);
            Grid[idx, d]++;

            board[row][column] = ch;
        }
        public void RemoveNumber(char ch, int row, int column, char[][] board)
        {
            int d = Int32.Parse(ch.ToString());

            Rows[row, d]--;
            Columns[column, d]--;
            var idx = GetIdx(row, column);
            Grid[idx, d]--;

            board[row][column] = '.';
        }

        public int GetIdx(int row, int column)
        {
            return (row / 3) * 3 + column / 3;
        }
        public void BackTrackSudoKu(int row, int column, char[][] board)
        {
            if (board[row][column] == '.')
            {
                for (int i = 1; i <= 9; i++)
                {
                    if (CouldPlace(i, row, column))
                    {
                        char ch = (char)(i + 48);
                        PlaceNumber(ch, row, column, board);
                        PlaceNextNumer(row, column, board);
                        if (!IsSudokuSolved)
                            RemoveNumber(ch, row, column, board);
                    }
                }

            }
            else
            {
                PlaceNextNumer(row, column, board);
            }
        }
        public void PlaceNextNumer(int row, int column, char[][] board)
        {
            if (row == 8 && column == 8)
            {
                IsSudokuSolved = true;
                return;
            }
            if (column == 8)
            {
                BackTrackSudoKu(row + 1, 0, board);
            }
            else
            {
                BackTrackSudoKu(row, column + 1, board);
            }
        }
        public bool CouldPlace(int d, int row, int column)
        {
            if (Rows[row, d] + Columns[column, d] + Grid[GetIdx(row, column), d] == 0)
                return true;
            return false;
        }
    }
}

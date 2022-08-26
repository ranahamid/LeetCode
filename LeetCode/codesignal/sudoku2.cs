using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codesignal
{
    internal class sudoku2
    {
        bool solution(char[][] grid)
        { 
            var N = 9;
            HashSet<char>[] rows = new HashSet<char>[N];
            HashSet<char>[] columns = new HashSet<char>[N];
            HashSet<char>[] boxes = new HashSet<char>[N];

            for (int i = 0; i < N; i++)
            {
                rows[i] = new HashSet<char>();
                columns[i] = new HashSet<char>();
                boxes[i] = new HashSet<char>();
            }
            for (int r = 0; r < N; r++)
            {
                for (int c = 0; c < N; c++)
                {
                    var val = grid[r][c];
                    if (val == '.')
                        continue;
                    if (rows[r].Contains(val))
                    {
                        return false;
                    }
                    rows[r].Add(val);

                    if (columns[c].Contains(val))
                    {
                        return false;
                    }
                    columns[c].Add(val);

                    var setIdx = (r / 3) * 3 + c / 3;
                    if (boxes[setIdx].Contains(val))
                    {
                        return false;
                    }
                    boxes[setIdx].Add(val);

                }
            }
            return true;

        }
    }
}

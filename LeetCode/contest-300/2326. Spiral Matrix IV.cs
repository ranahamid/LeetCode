using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.contest_300
{
    class _6111
    {
       public static int[][] SpiralMatrix(int m, int n, ListNode head)
        {
            var result = new int[m][];
            for (var i = 0; i < result.Length; i++)
                result[i] = new int[n];

            int rowBound = 0;
            int rowCount = m - 1;
            int ColumnBound = 0; 
            int columnCount = n - 1;

            while (rowBound <= rowCount && ColumnBound <= columnCount)
            {
                for (var i = ColumnBound; i <= columnCount; i++)
                {
                    var val = head != null ? head.val : -1;
                    if (head != null)
                        head = head.next;
                    result[rowBound][i] = val;
                }
                rowBound++;

                for (var i = rowBound; i <= rowCount; i++)
                {
                    var val = head != null ? head.val : -1;
                    if (head != null)
                        head = head.next;
                    result[i][columnCount] = val;
                }
                columnCount--;

                if (rowBound <= rowCount)
                {
                    for (var i = columnCount; i >= ColumnBound; i--)
                    {
                        var val = head != null ? head.val : -1;
                        if (head != null)
                            head = head.next;
                        result[rowCount][i] = val;
                    }
                }
                rowCount--;

                if (ColumnBound <= columnCount)
                {
                    for (var i = rowCount; i >= rowBound; i--)
                    {
                        var val = head != null ? head.val : -1;
                        if (head != null)
                            head = head.next;
                        result[i][ColumnBound] = val;
                    }
                }

                ColumnBound++;
            }
            return result;
        }
    }
}

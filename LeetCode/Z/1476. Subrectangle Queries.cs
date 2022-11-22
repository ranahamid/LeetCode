using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    /// <summary>
    /// Runtime 186 ms Beats 95.24% Memory 55.2 MB Beats 9.52%
    /// </summary>
    public class SubrectangleQueries
    {
        int[][] rec;
        public SubrectangleQueries(int[][] rectangle)
        {
            rec = rectangle;
        }

        public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
        {
            for (int i = row1; i <= row2; i++)
                for (int j = col1; j <= col2; j++)
                    rec[i][j] = newValue;
        }

        public int GetValue(int row, int col)
        {
            return rec[row][col];
        }
    }

    /**
     * Your SubrectangleQueries object will be instantiated and called as such:
     * SubrectangleQueries obj = new SubrectangleQueries(rectangle);
     * obj.UpdateSubrectangle(row1,col1,row2,col2,newValue);
     * int param_2 = obj.GetValue(row,col);
     */
}

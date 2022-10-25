using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    class BinaryMatrix
    {
        public int Get(int row, int col) { return 0; }
        public IList<int> Dimensions() { return new List<int>(); }
    }
    internal class _1428
    {
        /// <summary>
        /// Runtime 97 ms Beats 92.65% Memory 41.8 MB Beats 5.88%
        /// </summary>
        /// <param name="binaryMatrix"></param>
        /// <returns></returns>
        public int LeftMostColumnWithOne(BinaryMatrix binaryMatrix)
        {
            var dimension = binaryMatrix.Dimensions();
            var row = dimension[0];
            var col = dimension[1];

            var currentRow = 0;
            var currentCol = col - 1;

            while (currentRow < row && currentCol >= 0)
            {
                if (binaryMatrix.Get(currentRow, currentCol) == 0)
                {
                    currentRow++;
                }
                else
                {
                    currentCol--;
                }
            }


            if (currentCol == col - 1)
                return -1;
            else
                return currentCol + 1;
        }
        #region brute force
        public int LeftMostColumnWithOne_BruteForce(BinaryMatrix binaryMatrix)
        {
            var dimension = binaryMatrix.Dimensions();
            var row = dimension[0];
            var col = dimension[1];
            int min = col;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (binaryMatrix.Get(i, j) == 1)
                    {
                        min = Math.Min(min, j);
                        break;
                    }
                }
            }
            if (min == col)
                return -1;
            else
                return min;
        }
        #endregion
    }
}

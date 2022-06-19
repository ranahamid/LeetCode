using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _74_Search_a_2D_Matrix
    {
        #region binary inline
        
        /// <summary>
        /// Runtime: 98 ms, faster than 96.64% of C# online submissions for Search a 2D Matrix.
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            int row = matrix.Length - 1; var column = 0;
            while (row >= 0 && column < matrix[0].Length)
            {
                if (matrix[row][column] == target)
                {
                    return true;

                }
                if (matrix[row][column] < target)
                {

                    column++;
                }
                else
                {
                    row--;
                }

            }
            return false;
        }
        #endregion
        #region binary search 

        //int[][] nums = new int[3][]{
        //    new int[4]{1,3, 5,7},
        //    new int[4]{10,11,16,20},
        //    new int[4]{23,30,34,60}
        //};

        int[][] nums = new int[1][]{
                new int[1]{1}
            };
        /// <summary>
        /// Rank 1,489,809
        /// Runtime: 154 ms, faster than 28.74% of C# online submissions for Search a 2D Matrix.
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool SearchMatrix_2(int[][] matrix, int target)
        {
            var array = matrix.SelectMany(item => item).Distinct().ToArray();
            var res = BinarySearch(array, target);
            if (res >= 0) return true;
            else return false;
        }
        public static int BinarySearch(int[] nums, int target)
        {
            var start = 0;
            var end = nums.Length - 1;
            while (start <= end)
            {
                var mid = (end + start) / 2;
                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return -1;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1260
    {
        /// <summary>
        /// Runtime: 269 ms, faster than 40.00% of C# online submissions for Shift 2D Grid.
        /// Memory Usage: 46.1 MB, less than 53.33% of C# online submissions for Shift 2D Grid.
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static List<IList<int>> ShiftGrid(int[][] grid, int k)
        {
            if (grid == null)
                return null;
            var row = grid.Length;
            var column = grid[0].Length;
            k = k % (row * column);
            var nums = new int[row * column];
            int counter = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    nums[counter++] = grid[i][j];
                }
            }
            reverse(nums, 0, nums.Length - 1);// reverse all
            reverse(nums, 0, k - 1); //reverse first to k-1
            reverse(nums, k, nums.Length - 1); //reverse k to last
            counter = 0;
            var result = new List<IList<int>>();
            for (int i = 0; i < row; i++)
            {
                List<int> list = new List<int>();
                for (int j = 0; j < column; j++)
                {
                    list.Add(nums[counter++]);
                }
                result.Add(list);
            }
            return result;
        }
        public static void reverse(int[] nums, int i, int j)
        {
            while (i < j)
            {

                //(nums[i], nums[j]) = (nums[j], nums[i]);
                var temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                i++;
                j--;
            }

        }

    }
}

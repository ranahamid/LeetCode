using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _378
    {
        #region priorityQueue
        /// <summary>
        /// Runtime: 206 ms, faster than 55.51% of C# online submissions for Kth Smallest Element in a Sorted Matrix.
        /// Memory Usage: 42.7 MB, less than 42.91% of C# online submissions for Kth Smallest Element in a Sorted Matrix.
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int KthSmallest(int[][] matrix, int k)
        {
            PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    priorityQueue.Enqueue(matrix[i][j], -matrix[i][j]);
                }
            }
            int len = matrix.Length * matrix[0].Length - k;//6-1
            while (len-- != 0)
            {
                priorityQueue.Dequeue();
            }
            return priorityQueue.Peek();
        }
        #endregion
        #region Linq
        /// <summary>
        /// Runtime: 168 ms, faster than 55.51% of C# online submissions for Kth Smallest Element in a Sorted Matrix.
        /// Memory Usage: 42.7 MB, less than 42.91% of C# online submissions for Kth Smallest Element in a Sorted Matrix.
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int KthSmallest_Linq(int[][] matrix, int k)
        {
            return matrix.SelectMany(x => x).OrderBy(x => x).Skip(k - 1).FirstOrDefault();
        }
        #endregion
    }
}

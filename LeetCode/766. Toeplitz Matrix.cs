namespace LeetCode
{
    public class _766__Toeplitz_Matrix {
        
        /// <summary>
        /// Runtime: 139 ms, faster than 59.40% of C# online submissions for Toeplitz Matrix.
        /// Memory Usage: 41.4 MB, less than 51.13% of C# online submissions for Toeplitz Matrix.
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public bool IsToeplitzMatrix(int[][] matrix)
        {
            int row = matrix.Length;
            int column = matrix[0].Length;
            for (int i = 0; i < row-1; i++)
            {
                for (int j = 0; j < column-1; j++)
                {
                    if (matrix[i][j] != matrix[i + 1][j + 1])
                        return false;
                }
            }
            return true;
        }
    }
}
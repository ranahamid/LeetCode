namespace LeetCode.Z
{
    public class _2319__Check_if_Matrix_Is_X_Matrix
    {


        public static bool CheckXMatrix(int[][] grid)
        {
            var row = grid.Length;
            for (int i = 0; i < row; i++)
            {
                var column = grid[i].Length;
                for (int j = 0; j < column; j++)
                {
                    if (i == j || i + j == row - 1)
                    {
                        if (grid[i][j] == 0)
                            return false;
                    }
                    else
                    {
                        if (grid[i][j] != 0)
                            return false;
                    }
                }
            }

            return true;
        }


    }
}
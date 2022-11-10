using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1886
    {  /// <summary>
       ///Runtime: 156 ms, faster than 43.40% of C# online submissions for Determine Whether Matrix Can Be Obtained By Rotation.
       /// Memory Usage: 39.5 MB, less than 56.60% of C# online submissions for Determine Whether Matrix Can Be Obtained By Rotation.
       /// </summary>
       /// <param name="mat"></param>
       /// <param name="target"></param>
       /// <returns></returns>
        public bool FindRotation(int[][] mat, int[][] target)
        {
            bool a = true, b = true, c = true, d = true;
            var len = mat.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    if (mat[i][j] != target[i][j])
                        a = false;
                    if (mat[i][j] != target[len - j - 1][i])
                        b = false;
                    if (mat[i][j] != target[len - i - 1][len - j - 1])
                        c = false;
                    if (mat[i][j] != target[j][len - i - 1])
                        d = false;
                    if (a == false && b == false && c == false && d == false)
                        return false;
                }
            }
            return a || b || c || d;
        }
    }
}

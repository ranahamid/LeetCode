using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codesignal
{
    internal class rotateImage
    {
        /// <summary>
        /// https://www.geeksforgeeks.org/rotate-a-matrix-by-90-degree-in-clockwise-direction-without-using-any-extra-space/
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        int[][] solution(int[][] a)
        {
            
            // We first transpose the given matrix, and then reverse the content of individual rows to get the resultant 90 degree clockwise rotated matrix
            // Transpose of matrix
            for (int i=0; i < a.Length; i++)
            {
                for(int j=i+1;j<a.Length; j++)
                {
                    (a[i][j], a[j][i]) = (a[j][i], a[i][j]);
                }
            }
            //Reverse individual rows
            for(int i=0; i < a.Length; i++)
            {
                int low = 0, high = a.Length - 1;
                while (low < high)
                {
                    (a[i][low], a[i][high]) = (a[i][high], a[i][low]);

                    low++;
                    high--;
                }
            }
            return a;
        }

    }
}

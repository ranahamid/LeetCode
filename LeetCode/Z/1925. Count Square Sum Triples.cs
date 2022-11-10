using System;

namespace LeetCode.Z
{
    public class _1925__Count_Square_Sum_Triples
    {

        /// <summary>
        /// Runtime: 190 ms, faster than 13.79% of C# online submissions for Count Square Sum Triples.
        /// Memory Usage: 25.4 MB, less than 67.24% of C# online submissions for Count Square Sum Triples.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int CountTriples(int n)
        {
            int counter = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    var sqValue = Math.Sqrt(Math.Pow(i, 2) + Math.Pow(j, 2));
                    if (sqValue % 1 == 0 && sqValue <= n)
                        counter++;
                }
            }

            return counter;
        }
    }
}
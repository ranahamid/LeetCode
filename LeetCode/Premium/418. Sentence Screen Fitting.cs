using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _418
    {
        /// <summary>
        /// Runtime 3109 ms Beats 9.30% Memory 37.8 MB Beats 37.21%
        /// SOLVED in 1st attempt. Didn't thought that it will solved in first chance
        /// </summary>
        /// <param name="sentence"></param>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public int WordsTyping(string[] sentence, int rows, int cols)
        {
            int result = 0;
            var counter = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    while (sentence[counter].Length <= cols - j)
                    {
                        j += sentence[counter].Length + 1;
                        counter++;
                        if (counter >= sentence.Length)
                        {
                            result++;
                            counter = 0;
                        }
                    }
                }
            }
            return result;
        }
    }
}

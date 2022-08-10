using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _422
    {
        /// <summary>
        /// Runtime: 112 ms, faster than 100.00% of C# online submissions for Valid Word Square.
        /// Memory Usage: 42.2 MB, less than 19.05% of C# online submissions for Valid Word Square.
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public bool ValidWordSquare(IList<string> words)
        {
            for (int i = 0; i < words.Count; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (j >= words.Count || i >= words[j].Length || words[i][j] != words[j][i])
                        return false;
                }
            }
            return true;
        }
    }
}

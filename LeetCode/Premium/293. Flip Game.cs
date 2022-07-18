using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _293
    {    /// <summary>
         /// Runtime: 159 ms, faster than 90.91% of C# online submissions for Flip Game.
         /// Memory Usage: 43.6 MB, less than 18.18% of C# online submissions for Flip Game.
         /// </summary>
         /// <param name="currentState"></param>
         /// <returns></returns>
        public IList<string> GeneratePossibleNextMoves(string currentState)
        {
            var result = new List<string>();
            var sb = new StringBuilder(currentState);
            for (int i = 0; i < sb.Length - 1; i++)
            {
                if (sb[i] == '+' && sb[i + 1] == '+')
                {
                    sb[i] = '-';
                    sb[i + 1] = '-';
                    result.Add(sb.ToString());
                    sb[i] = '+';
                    sb[i + 1] = '+';
                }
            }
            return result;
        }
    }
}

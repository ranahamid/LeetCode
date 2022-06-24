using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1812_Determine_Color_of_a_Chessboard_Square
    {
        /// <summary>
        /// Runtime: 82 ms, faster than 88.75% of C# online submissions for Determine Color of a Chessboard Square.
        /// Memory Usage: 36.8 MB, less than 47.50% of C# online submissions for Determine Color of a Chessboard Square.
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        public static bool SquareIsWhite(string coordinates)
        {
            var chars = coordinates.ToCharArray();
            var sum = chars[0] + chars[1];
            if (sum % 2 == 1)
                return true;
            else
                return false;
        }
    }
}

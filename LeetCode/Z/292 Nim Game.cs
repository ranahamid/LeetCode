using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _292_Nim_Game
    {

        public static bool CanWinNim(int n)
        {
            return n % 4 != 0;
        }
        /// <summary>
        /// Runtime: 38 ms, faster than 82.31% of C# online submissions for Nim Game.
        /// Memory Usage: 27 MB, less than 52.38% of C# online submissions for Nim Game.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool CanWinNim_2(int n)
        {
            return n % 4 == 0 ? false : true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1496
    {
        /// <summary>
        /// Runtime: 103 ms, faster than 70.21% of C# online submissions for Path Crossing.
        /// Memory Usage: 37.4 MB, less than 74.47% of C# online submissions for Path Crossing.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool IsPathCrossing(string path)
        {
            var list = new List<string>();
            int x = 0, y = 0;
            var numInStr = "(" + x.ToString() + "),(" + y.ToString() + ")";
            list.Add(numInStr);

            foreach (var ch in path)
            {
                if (ch == 'N')
                {
                    y++;
                }
                else if (ch == 'S')
                {
                    y--;
                }
                else if (ch == 'E')
                {
                    x++;
                }
                else if (ch == 'W')
                {
                    x--;
                }
                numInStr = "(" + x.ToString() + "),(" + y.ToString() + ")";
                if (list.Contains(numInStr))
                    return true;
                list.Add(numInStr);
            }
            return false;
        }
    }
}

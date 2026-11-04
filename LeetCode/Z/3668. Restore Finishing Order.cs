using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _3668
    {
        public int[] RecoverOrder(int[] order, int[] friends)
        {
            var result = new List<int>();
            foreach (var f in order)
            {
                if (friends.Contains(f))
                {
                    result.Add(f);
                }
            }
            return result.ToArray();
        }
    }
}

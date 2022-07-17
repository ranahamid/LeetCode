using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1256
    {
        public static string Encode(int num)
        {
            var bin = Convert.ToString(num + 1, 2);
            return bin.Substring(1);
        }
    }
}

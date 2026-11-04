using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _3783
    {
        public int MirrorDistance(int n)
        {
            return Math.Abs(n - Int32.Parse(n.ToString().Reverse().ToArray()));
        }

        /// <summary>
        /// ////////////
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int MirrorDistance_2(int n)
        {
            return Math.Abs(n - Reverse(n));
        }
        public int Reverse(int n)
        {
            int rev = 0;
            while (n > 0)
            {
                rev = rev * 10 + n % 10;
                n /= 10;
            }
            return rev;
        }

    }
}

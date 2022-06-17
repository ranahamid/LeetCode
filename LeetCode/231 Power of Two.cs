using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Power_of_Two
    {
        /// <summary>
        /// 231. Power of Two
        /// 45 ms
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsPowerOfTwo(int n)
        {
            if (n <= 0)
                return false;
            return n > 0 && (n & n - 1) == 0;
        }
        /// <summary>
        /// 52 ms
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsPowerOfTwo_2(int n)
        {
            return n > 0 && (n & n - 1) == 0;
        }    
    }
}

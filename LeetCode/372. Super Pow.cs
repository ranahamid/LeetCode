using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _372
    {
        /// <summary>
        /// Runtime: 525 ms, faster than 9.09% of C# online submissions for Super Pow.
        /// Memory Usage: 46.5 MB, less than 9.09% of C# online submissions for Super Pow.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int SuperPow(int x, int[] b)
        {
            List<int> list = new List<int>();
            foreach (var item in b)
            {
                list.Add(item);
            }
            list.Reverse();
            var str = "";
            foreach (var item in list)
            {
                str = item + str;
            }
            BigInteger n = BigInteger.Parse(str);
            BigInteger num = BigInteger.Parse(str);
            if (n < 0) //No need for this problem
            {
                x = 1 / x;
                num = n;
                num = num * -1;
            }
            return (int)FastPow(x, num);
        }
        public BigInteger FastPow(BigInteger a, BigInteger n)
        {
            if (n == 0)
                return 1;
            var subSum = (FastPow(a, n / 2)) % 1337;
            var subSquare = (subSum * subSum) % 1337;
            if (n % 2 == 1)
                return (a * subSquare) % 1337;
            else
                return subSquare;
        }

    }
}

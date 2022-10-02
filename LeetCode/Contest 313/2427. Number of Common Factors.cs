using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_313
{
    internal class _2427
    {
        /// <summary>
        /// Runtime 37 ms Beats 100%
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int CommonFactors(int a, int b)
        {
            var max = Math.Max(a, b);
            var counter = 0;
            for (int i = 1; i <= max; i++)
            {
                if (a % i == 0 && b % i == 0)
                    counter++;
            }
            return counter;
        }
        #region GFG
        
        static Dictionary<int, int> ma = new Dictionary<int, int>();
        public int CommonFactors_1(int a, int b)
        {
            ma = new Dictionary<int,
                                               int>();

            return commDiv(a, b);
        }
        static int commDiv(int a, int b)
        {
            primeFactorize(a);
            int res = 1;
            foreach (KeyValuePair<int, int> m in ma)
            {
                int cnt = 0;
                int key = m.Key;
                int value = m.Value;

                while (b % key == 0)
                {
                    b /= key;
                    cnt++;
                }
                res *= (Math.Min(cnt, value) + 1);
            }
            return res;
        }
        static void primeFactorize(int a)
        {
            for (int i = 2; i * i <= a; i += 1)
            {
                int cnt = 0;
                while (a % i == 0)
                {
                    cnt++;
                    a /= i;
                }
                ma.Add(i, cnt);
            }

            if (a > 1)
                ma.Add(a, 1);
        }
        #endregion
    }
}

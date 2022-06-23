using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _258_Add_Digits
    {

        /// <summary>
        /// Runtime: 24 ms, faster than 93.55% of C# online submissions for Add Digits.
        /// Memory Usage: 27.8 MB, less than 8.47% of C# online submissions for Add Digits.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int AddDigits(int num)
        {

            while (num > 9)
            {
                var digits = GetDigits(num);
                num = digits.Sum();
            }
            return num;
        }
        public static List<int> GetDigits(int num)
        {
            var list = new List<int>();
            while (num != 0)
            {
                var value = num % 10;
                list.Add(value);
                num = num / 10;
            }
            return list;
        }

    }
}

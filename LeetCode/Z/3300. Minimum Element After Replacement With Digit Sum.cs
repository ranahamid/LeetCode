using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _3300
    {
        public int MinElement(int[] nums)
        {
            var list = new List<int>();
            foreach (var num in nums)
            {
                var digitSum = DigitSum(num);
                list.Add(digitSum);

            }
            return list.Min();
        }
        public int DigitSum(int n)
        {
            var sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
    }
}

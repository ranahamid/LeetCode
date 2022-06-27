using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1742_Maximum_Number_of_Balls_in_a_Box
    {
        /// <summary>
        /// Runtime: 87 ms, faster than 28.57% of C# online submissions for Maximum Number of Balls in a Box.
        /// Memory Usage: 25.9 MB, less than 82.14% of C# online submissions for Maximum Number of Balls in a Box.
        /// </summary>
        /// <param name="lowLimit"></param>
        /// <param name="highLimit"></param>
        /// <returns></returns>
        public static int CountBalls(int lowLimit, int highLimit)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = lowLimit; i <= highLimit; i++)
            {
                var digitSum = GetDigitSum(i);
                if (result.ContainsKey(digitSum))
                {
                    result[digitSum]++;
                }
                else
                {
                    result[digitSum] = 1;
                }
            }
            int maxVal = 0;
            foreach (var item in result)
            {
                maxVal = Math.Max(maxVal, item.Value);
            }
            return maxVal;
        }

        public static int GetDigitSum(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                var value = num % 10;
                sum = sum + value;
                num = num / 10;
            }
            return sum;
        }

    }
}

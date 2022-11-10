using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1323_Maximum_69_Number
    {
        /// <summary>
        /// string
        /// Runtime 44 ms Beats 39.65% Memory 24.9 MB Beats 98.22%
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int Maximum69Number_s(int num)
        {
            var nums = new StringBuilder(num.ToString());
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] == '6')
                {
                    nums[i] = '9';
                    break;
                }
            return int.Parse(nums.ToString());

        }

        /// <summary>
        /// Runtime: 48 ms, faster than 7.14% of C# online submissions for Maximum 69 Number.
        /// Memory Usage: 25.6 MB, less than 25.00% of C# online submissions for Maximum 69 Number.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>

        public static int Maximum69Number(int num)
        {
            var digits = GetDigits(num);
            int result = 0;
            var isChanged = false;
            for (int i = digits.Count - 1; i >= 0; i--)
            {
                if (digits[i] == 6 && !isChanged)
                {
                    digits[i] = 9;
                    isChanged = true;
                }
                result = result * 10 + digits[i];
            }
            return result;
        }

        /// <summary>
        /// Runtime: 40 ms, faster than 19.05% of C# online submissions for Maximum 69 Number.
        /// Memory Usage: 25.7 MB, less than 25.00% of C# online submissions for Maximum 69 Number.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>

        public static int Maximum69Number_2(int num)
        {
            var digits = GetDigits(num);
            int result = 0;
            for (int i = digits.Count - 1; i >= 0; i--)
            {
                if (digits[i] == 6)
                {
                    digits[i] = 9;
                    break;
                }
            }
            for (int i = digits.Count - 1; i >= 0; i--)
            {
                result = result * 10 + digits[i];
            }
            return result;
        }
        public static List<int> GetDigits(int num)
        {
            List<int> digitList = new List<int>();
            while (num != 0)
            {
                var val = num % 10;
                digitList.Add(val);
                num = num / 10;
            }
            return digitList;
        }

    }
}

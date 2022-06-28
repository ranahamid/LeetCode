using System;
using System.Collections.Generic;
namespace LeetCode
{
    public class _2283_Check_if_Number_Has_Equal_Digit_Count_and_Digit_Value
    {
        /// <summary>
        /// Runtime: 118 ms, faster than 42.13% of C# online submissions for Check if Number Has Equal Digit Count and Digit Value.
        /// Memory Usage: 37.2 MB, less than 77.16% of C# online submissions for Check if Number Has Equal Digit Count and Digit Value.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool DigitCount(string num)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            var chars = num.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                var n = num[i] - 48;
                if (dictionary.ContainsKey(n))
                {
                    dictionary[n]++;
                }
                else
                {
                    dictionary[n] = 1;
                }
            }

            for (int i = 0; i < chars.Length; i++)
            {
                var occur = num[i] - 48;
                if (dictionary.ContainsKey(i))
                {
                    if (dictionary[i] != occur)
                        return false;
                }
                else if(occur!=0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
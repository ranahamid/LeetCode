using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _65
    {
        /// <summary>
        /// Runtime: 73 ms, faster than 98.63% of C# online submissions for Valid Number.
        /// Memory Usage: 41.4 MB, less than 15.07% of C# online submissions for Valid Number.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsNumber(string s)
        {
            bool isDigit = false, isExponent = false, isDot = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    isDigit = true;
                }
                else if (s[i] == '+' || s[i] == '-')
                {
                    if (i == 0)
                        continue;
                    if (isExponent == true && (s[i - 1] == 'e' || s[i - 1] == 'E'))
                        continue;
                    return false;
                }
                else if (s[i] == 'e' || s[i] == 'E')
                {
                    if (isExponent == true || isDigit == false)
                        return false;
                    isExponent = true;
                    isDigit = false;
                }
                else if (s[i] == '.')
                {
                    if (isExponent || isDot)
                        return false;
                    isDot = true;
                }
                else
                    return false;
            }
            return isDigit;
        }
    }
}

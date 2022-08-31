using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1736
    {
        /// <summary>
        /// Runtime: 116 ms, faster than 45.00% of C# online submissions for Latest Time by Replacing Hidden Digits.
        /// Memory Usage: 36 MB, less than 50.00% of C# online submissions for Latest Time by Replacing Hidden Digits.
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public string MaximumTime(string time)
        {
            var sb = new StringBuilder(time); var isOnePass = false;
            if (sb[0] == '?')
            {

                if (sb[1] == '?')
                {
                    sb[0] = '2';
                    sb[1] = '3';
                    isOnePass = true;
                }
                else
                {
                    if (sb[1] >= '4' && sb[1] <= '9')
                        sb[0] = '1';
                    else
                        sb[0] = '2';
                }
            }
            if (isOnePass == false && sb[1] == '?')
            {
                if (sb[0] == '2')
                    sb[1] = '3';
                else
                    sb[1] = '9';
            }
            //minute 
            if (sb[3] == '?')
            {
                sb[3] = '5';
            }
            if (sb[4] == '?')
            {
                sb[4] = '9';
            }

            return sb.ToString();
        }
    }
}

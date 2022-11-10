using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1404
    {
        /// <summary>
        /// Runtime 102 ms Beats 72.88% Memory 34.6 MB Beats 52.54%
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int NumSteps(string s)
        {
            var steps = 0;
            var reminder = 0;
            for (int i = s.Length - 1; i >= 1; i--)
            {
                if (s[i] - '0' + reminder == 1) // s.charAt(i) + carry could have (0, 1, or 2) values; 0, 2 means its even, 1 means ODD
                {
                    // so if odd, we first need to ADD 1 (1st step) and then DIVIDE BY 2 (2nd step); so basically there are 2 steps involved
                    steps += 2;// as discussed, we have 2 steps involved when number is ODD
                    reminder = 1; // to handle ODD, we use carry for next number
                }
                else
                {
                    steps += 1;// if num os NOT ODD, we only divide by 2, menaing onely 1 step
                }
            }
            // notice I have run the for loop only until second last digit (from right to left)
            // We know for sure the leading number is 1
            // so if there was a carry (carry = 1), it will become 1 + 1 and hence we need to divide 1 more time
            // But is carry = 0, we have got to 1 (required number)
            return steps + reminder;
        }
    }
}

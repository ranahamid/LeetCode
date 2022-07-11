using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _66
    {
        /// <summary>
        /// Runtime: 218 ms, faster than 34.41% of C# online submissions for Plus One.
        /// Memory Usage: 40.8 MB, less than 81.77% of C# online submissions for Plus One.
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public static int[] PlusOne(int[] digits)
        {
            List<int> result = new List<int>(); int carry = 0;
            for (int i = digits.Length - 1; i >= 0; i--)
            {

                var nmbr = digits[i];
                if (i == digits.Length - 1)
                {
                    nmbr = nmbr + 1;
                    if (nmbr == 10)
                    {
                        carry = 1;
                        nmbr = 0;
                    }
                    else
                    {
                        carry = 0;
                    }
                }
                else
                {
                    nmbr = nmbr + carry;
                    if (nmbr == 10)
                    {
                        carry = 1;
                        nmbr = 0;
                    }
                    else
                    {
                        carry = 0;
                    }
                }

                result.Add(nmbr);
            }
            if (carry == 1)
            {
                result.Add(1);
            }
            result.Reverse();
            return result.ToArray();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _860
    {
        /// <summary>
        /// Runtime: 279 ms, faster than 76.34% of C# online submissions for Lemonade Change.
        /// Memory Usage: 47.4 MB, less than 78.49% of C# online submissions for Lemonade Change.
        /// </summary>
        /// <param name="bills"></param>
        /// <returns></returns>
        public bool LemonadeChange(int[] bills)
        {
            var five = 0;
            var ten = 0;
            var twenty = 0;
            foreach (var item in bills)
            {
                if (item == 5)
                {
                    five++;
                }
                else
                {
                    //check if can return 

                    if (item == 10)
                    {
                        if (five > 0)
                        {
                            five--;
                        }
                        else
                        {
                            return false;
                        }
                        ten++;
                    }
                    else if (item == 20)
                    {
                        var remaining = 15;
                        if (ten > 0)
                        {
                            ten--;
                            remaining = 5;
                        }
                        var fiveCount = remaining / 5;
                        if (five >= fiveCount)
                        {
                            five = five - fiveCount;
                        }
                        else
                        {
                            return false;
                        }
                        twenty++;
                    }
                }
            }
            return true;
        }
    }
}

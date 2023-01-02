using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2520
    {
        /// <summary>
        /// Runtime 31 ms Beats 100% Sorry, there are not enough accepted submissions to show data Memory 27 MB Beats 100%
        /// </summary>
        public class Solution
        {
            public int CountDigits(int num)
            {

                var counter = 0;
                var result = GetDigits(num);
                foreach (var item in result)
                {
                    if (num % item == 0)
                    {
                        counter++;
                    }
                }
                return counter;
            }
            public List<int> GetDigits(int num)
            {
                List<int> result = new List<int>();
                while (num != 0)
                {
                    var temp = num % 10;
                    result.Add(temp);
                    num /= 10;
                }
                return result;
            }
        }
    }
}

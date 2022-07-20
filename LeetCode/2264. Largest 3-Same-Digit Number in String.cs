using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.NOT_SUBMITTED
{
    internal class _2264
    {
        /// <summary>
        /// Runtime: 110 ms, faster than 54.55% of C# online submissions for Largest 3-Same-Digit Number in String.
        /// Memory Usage: 37.7 MB, less than 18.18% of C# online submissions for Largest 3-Same-Digit Number in String.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string LargestGoodInteger(string num)
        {
            var result = new HashSet<string>();
            for (int i = 0; i < num.Length - 2; i++)
            {
                if (num[i] == num[i + 1] && num[i] == num[i + 2])
                {
                    result.Add(num[i].ToString() + num[i].ToString() + num[i].ToString());
                }
            }
            result = result.OrderByDescending(x => x).ToHashSet();
            var data = result.FirstOrDefault();
            return data != null ? data : "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _246
    {
        /// <summary>
        /// Runtime: 83 ms, faster than 84.03% of C# online submissions for Strobogrammatic Number.
        /// Memory Usage: 38.1 MB, less than 5.04% of C# online submissions for Strobogrammatic Number.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool IsStrobogrammatic(string num)
        {
            var subnm = new List<char>() { '0', '1', '8', '6', '9' };
            var revNum = new StringBuilder();
            foreach (var item in num)
            {
                if (!subnm.Contains(item))
                {
                    return false;
                }
                if (item == '6')
                    revNum.Append("9");
                else if (item == '9')
                    revNum.Append("6");
                else
                    revNum.Append(item.ToString());
            }
            var revStr = new string(revNum.ToString().ToCharArray().Reverse().ToArray());
            if (revStr == num)
                return true;
            else
                return false;
        }
    }
}

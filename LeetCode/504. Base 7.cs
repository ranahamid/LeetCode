using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _504
    {/// <summary>
     /// Runtime: 97 ms, faster than 50.98% of C# online submissions for Base 7.
     /// Memory Usage: 35.5 MB, less than 78.43% of C# online submissions for Base 7
     /// </summary>
     /// <param name="num"></param>
     /// <returns></returns>

        public string ConvertToBase7(int num)
        {
            if (num < 0)
            {
                return "-" + ConvertToBase7(num * -1);
            }
            if (num < 7)
            {
                return num.ToString();
            }
            else
            {
                return ConvertToBase7(num / 7) + num % 7;
            }
        }
    }
}

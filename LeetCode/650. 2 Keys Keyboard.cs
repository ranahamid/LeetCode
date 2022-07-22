using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _650
    { /// <summary>
      /// Runtime: 35 ms, faster than 70.27% of C# online submissions for 2 Keys Keyboard.
      /// Memory Usage: 25.2 MB, less than 75.68% of C# online submissions for 2 Keys Keyboard.
      /// </summary>
      /// <param name="n"></param>
      /// <returns></returns>
        public static int MinSteps(int n)
        {
            int result = 0;
            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    n = n / i;
                    result = result + i;
                }
            }
            return result;
        }
    }
}

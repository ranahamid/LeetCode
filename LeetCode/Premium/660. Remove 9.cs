using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _660
    {
        /// <summary>
        /// Runtime: 35 ms, faster than 33.33% of C# online submissions for Remove 9.
        /// Memory Usage: 25.2 MB, less than 100.00% of C# online submissions for Remove 9.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NewInteger(int n)
        {
            StringBuilder sb =new  StringBuilder();
            while (n > 0)
            {
                sb = new StringBuilder((n % 9).ToString() + sb);
                n /= 9;
            }
            return Int32.Parse(sb.ToString());
        }

        /// <summary>
        /// Runtime: 34 ms, faster than 33.33% of C# online submissions for Remove 9.
        /// Memory Usage: 25.1 MB, less than 100.00% of C# online submissions for Remove 9.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NewInteger_1(int n)
        {
            string sb = string.Empty;
            while (n > 0)
            {
                sb = (n % 9).ToString() + sb;
                n /= 9;
            }
            return Int32.Parse(sb);
        }
    }
}

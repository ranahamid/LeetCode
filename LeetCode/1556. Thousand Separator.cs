using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1556
    {
        /// <summary>
        /// Runtime: 71 ms, faster than 98.08% of C# online submissions for Thousand Separator.
        /// Memory Usage: 36.6 MB, less than 7.69% of C# online submissions for Thousand Separator.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string ThousandSeparator(int n)
        {
            var st = n.ToString();
            var list = new List<string>();
            var len = st.Length;
            while (len >= 0)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 3; i++)
                {
                    len--;
                    if (len >= 0)
                        sb.Append(st[len]);
                }
                if (sb.Length > 0)
                    list.Add(new string(sb.ToString().Reverse().ToArray()));
            }
            list.Reverse();
            var result = string.Join('.', list);
            return result;
        }
    }
}

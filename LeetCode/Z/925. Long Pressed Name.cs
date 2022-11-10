using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _925
    {
        /// <summary>
        /// Runtime: 99 ms, faster than 64.86% of C# online submissions for Long Pressed Name.
        /// Memory Usage: 37 MB, less than 31.08% of C# online submissions for Long Pressed Name.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="typed"></param>
        /// <returns></returns>
        public bool IsLongPressedName(string name, string typed)
        {
            int j = 0;
            int i = 0;
            for (i = 0; i < name.Length; i++)
            {
                if (j >= typed.Length)
                    return false;
                if (name[i] == typed[j])
                {
                    j++;
                    continue;

                }
                while (j < typed.Length && name[i] != typed[j])
                {
                    if (j > 0 && typed[j - 1] == typed[j])
                        j++;
                    else
                        return false;
                }
                j++;
            }
            var temp = j;
            for (int k = temp; k < typed.Length; k++)
            {
                if (typed[k] == typed[k - 1])
                {
                    j++;
                }
            }
            if (j == typed.Length && i == name.Length)
                return true;
            return false;
        }
    }
}

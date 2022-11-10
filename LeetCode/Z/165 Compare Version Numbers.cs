using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _165_Compare_Version_Numbers
    {

        /// <summary>
        /// 
        /// Runtime: 82 ms, faster than 58.28% of C# online submissions for Compare Version Numbers.
        /// Memory Usage: 35.1 MB, less than 76.07% of C# online submissions for Compare Version Numbers.
        /// </summary>
        /// <param name="version1"></param>
        /// <param name="version2"></param>
        /// <returns></returns>
        public static int CompareVersion(string version1, string version2)
        {
            var v1 = version1.Split('.');
            var v2 = version2.Split('.');
            var firstLen = v1.Length;
            var seconddLen = v2.Length;
            var max = Math.Max(firstLen, seconddLen);

            for (int i = 0; i < max; i++)
            {
                var firstDigits = 0;
                if (i < firstLen && !string.IsNullOrEmpty(v1[i]))
                {
                    int.TryParse(v1[i], out firstDigits);
                }


                var secondDigits = 0;
                if (i < seconddLen && !string.IsNullOrEmpty(v2[i]))
                {
                    int.TryParse(v2[i], out secondDigits);
                }
                if (firstDigits > secondDigits)
                    return 1;
                else if (firstDigits < secondDigits)
                    return -1;
            }
            return 0;
        }
    }
}

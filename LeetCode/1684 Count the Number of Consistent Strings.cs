using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1684_Count_the_Number_of_Consistent_Strings
    {
        /// <summary>
        /// Runtime: 164 ms, faster than 54.49% of C# online submissions for Count the Number of Consistent Strings.
        /// Memory Usage: 43.9 MB, less than 39.10% of C# online submissions for Count the Number of Consistent Strings.
        /// </summary>
        /// <param name="allowed"></param>
        /// <param name="words"></param>
        /// <returns></returns>

        public static int CountConsistentStrings(string allowed, string[] words)
        {
            var allowChars = allowed.ToCharArray();
            var counter = 0;
            foreach (var item in words)
            {
                var itemChars = item.ToCharArray();
                bool isSuccess = true;
                for (int i = 0; i < itemChars.Length; i++)
                {
                    if (!allowChars.Contains(itemChars[i]))
                    {
                        isSuccess = false;
                        break;
                    }
                }
                if (isSuccess)
                {
                    counter++;
                }
            }
            return counter;
        }


    }
}

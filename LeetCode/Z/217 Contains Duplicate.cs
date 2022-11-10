using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class Contains_Duplicate
    {
        /// <summary>
        /// Runtime: 203 ms, faster than 78.00% of C# online submissions for Contains Duplicate.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> resultDic = new HashSet<int>();
            foreach (var item in nums)
            {
                if (resultDic.Contains(item))
                {
                    return true;
                }
                else
                {
                    resultDic.Add(item);
                }
            }
            return false;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1773_Count_Items_Matching_a_Rule
    {
        /// <summary>
        /// Runtime: 255 ms, faster than 10.69% of C# online submissions for Count Items Matching a Rule.
        /// Memory Usage: 45.8 MB, less than 82.39% of C# online submissions for Count Items Matching a Rule.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="ruleKey"></param>
        /// <param name="ruleValue"></param>
        /// <returns></returns>
        public static int CountMatches(List<IList<string>> items, string ruleKey, string ruleValue)
        {
            var counter = 0;
            foreach (var item in items)
            {
                if (ruleKey == "type" && item[0] != ruleValue || ruleKey == "color" && item[1] != ruleValue || ruleKey == "name" && item[2] != ruleValue)
                {
                    continue;
                }
                counter++;
            }
            return counter;
        }

    }
}

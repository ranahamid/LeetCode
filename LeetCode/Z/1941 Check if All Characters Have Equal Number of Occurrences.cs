using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1941_Check_if_All_Characters_Have_Equal_Number_of_Occurrences
    {

        /// <summary>
        /// Runtime: 93 ms, faster than 70.75% of C# online submissions for Check if All Characters Have Equal Number of Occurrences.
        /// Memory Usage: 37.3 MB, less than 35.85% of C# online submissions for Check if All Characters Have Equal Number of Occurrences.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool AreOccurrencesEqual(string s)
        {
            var chars = s.ToCharArray();
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (char c in chars)
            {
                if (map.ContainsKey(c))
                {
                    map[c] = map[c] + 1;
                }
                else
                {
                    map.Add(c, 1);
                }
            }


            if (map.Count > 1)
            {
                var firstVal = map.ElementAt(0).Value;
                foreach (var item in map)
                {

                    if (item.Value != firstVal)
                    {
                        return false;
                    }
                }

            }
            return true;
        }

        /// <summary>
        /// Runtime: 113 ms, faster than 41.51% of C# online submissions for Check if All Characters Have Equal Number of Occurrences.
        /// Memory Usage: 37.6 MB, less than 32.08% of C# online submissions for Check if All Characters Have Equal Number of Occurrences.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool AreOccurrencesEqual_2(string s)
        {
            var chars = s.ToCharArray();
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (char c in chars)
            {
                if (map.ContainsKey(c))
                {
                    map[c] = map[c] + 1;
                }
                else
                {
                    map.Add(c, 1);
                }
            }

            var occuran = new List<int>();
            if (map.Count > 1)
            {
                foreach (var item in map)
                {
                    occuran.Add(item.Value);
                }
                var firstVal = occuran.FirstOrDefault();
                foreach (var item in occuran)
                {
                    if (item != firstVal)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}

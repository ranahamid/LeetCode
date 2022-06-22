using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _771_Jewels_and_Stones
    {
        /// <summary>
     /// Runtime: 74 ms, faster than 73.07% of C# online submissions for Jewels and Stones.
     /// Memory Usage: 35.9 MB, less than 34.16% of C# online submissions for Jewels and Stones.
     /// </summary>
     /// <param name="jewels"></param>
     /// <param name="stones"></param>
     /// <returns></returns>
        public int NumJewelsInStones(string jewels, string stones)
        {
            var jw = jewels.ToCharArray();
            var st = stones.ToCharArray();
            var counter = 0;
            for (int i = 0; i < st.Length; i++)
            {
                if (jw.Contains(st[i]))
                    counter++;
            }
            return counter;
        }
    }
}

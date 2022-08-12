using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _830
    {
        public class CountResult
        {
            public int Start { get; set; }
            public int End { get; set; }
        }
        /// <summary>
        /// Runtime: 146 ms, faster than 84.91% of C# online submissions for Positions of Large Groups.
        /// Memory Usage: 44 MB, less than 7.55% of C# online submissions for Positions of Large Groups.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public IList<IList<int>> LargeGroupPositions(string s)
        {
            List<IList<int>> result = new List<IList<int>>();

            if (s.Length < 2)
                return result;
            Dictionary<char, CountResult> dic = new Dictionary<char, CountResult>();
            var prev = s[0];
            var start = 0;
            var end = 0; 
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    end = i; 
                }
                else
                {
                    if (end - start >= 2)
                    {
                        result.Add(new List<int> { start, end });
                    }
                    start = i;
                    end = i; 
                }
            }
            if ( end - start >= 2)
            {
                result.Add(new List<int> { start, end });
            }

            return result;
        }
    }
}

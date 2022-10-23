using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_315
{
    internal class _2442
    {
        public int CountDistinctIntegers(int[] nums)
        {
            var hashset = new HashSet<int>(nums);
            var result = new HashSet<int>();
            int answer = 0;
            foreach (var item in hashset)
            {
                answer = GetReverse(item);
                result.Add(answer);
            }
            hashset.UnionWith(result);
            return hashset.Count();
        }
        static int GetReverse(int source)
        {
            var answer = 0;
            while (source > 0)
            {
                var digit = source % 10;
                answer = answer * 10 + digit;
                source = source / 10;
            }
            return answer;
        }
    }
}

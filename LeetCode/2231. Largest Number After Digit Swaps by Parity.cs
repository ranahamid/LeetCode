using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2231
    {
        /// <summary>
        /// Runtime: 23 ms, faster than 93.33% of C# online submissions for Largest Number After Digit Swaps by Parity.
        /// Memory Usage: 26.3 MB, less than 37.78% of C# online submissions for Largest Number After Digit Swaps by Parity.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int LargestInteger(int num)
        { 
            var evenList = new List<int>();
            var oddList = new List<int>();
            var source = num;
            while (source > 0)
            {
                var digit = source % 10;
                if (digit % 2 == 0)
                    evenList.Add(digit);
                else
                    oddList.Add(digit);
                source = source / 10;
            }
            oddList.Sort((a, b) => a.CompareTo(b));
            evenList.Sort((a, b) => a.CompareTo(b));
            source = num;
            var sb = new StringBuilder();
            var evenCount = 0;
            var oddCount = 0;
            while (source > 0)
            {
                var digit = source % 10;
                if (digit % 2 == 0)
                    sb.Append(evenList[evenCount++]);
                else
                    sb.Append(oddList[oddCount++]);
                source = source / 10;
            }
            var res = new string(sb.ToString().Reverse().ToArray());
            var result = Int32.Parse(res);
            return result;
        }
     
    }
}

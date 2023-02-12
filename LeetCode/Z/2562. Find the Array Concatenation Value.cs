using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2562
    {
        /// <summary>
        /// Runtime: 91 ms, faster than 100.00% of C# online submissions for Find the Array Concatenation Value.
        /// Memory Usage: 40.9 MB, less than 100.00% of C# online submissions for Find the Array Concatenation Value.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public long FindTheArrayConcVal(int[] nums)
        {

            long sum = 0;
            var numbers = new List<int>();
            foreach (var n in nums)
                numbers.Add(n);
            while (numbers.Any())
            {
                var first = numbers.First(); 
                numbers.RemoveAt(0);

                if (numbers.Any())
                {
                    var second  = numbers.Last();
                    numbers.RemoveAt(numbers.Count - 1); 

                    var s = first.ToString() + second.ToString();
                    var nms = long.Parse(s);
                    sum += nms;
                }
                else
                    sum += first;

            }
            return sum;
        }
    }
}

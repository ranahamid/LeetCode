using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _985
    {
        /// <summary>
        /// Runtime: 301 ms, faster than 92.86% of C# online submissions for Sum of Even Numbers After Queries.
        /// Memory Usage: 50.9 MB, less than 64.29% of C# online submissions for Sum of Even Numbers After Queries.
        /// </summary>
        public class Result
        {
            public int number { get; set; }
            public bool IsEven { get; set; }
        }
        public int[] SumEvenAfterQueries(int[] nums, int[][] queries)
        {
            var output = new int[queries.Length];
            var result = new List<Result>();
            var sum = 0;
            foreach (var item in nums)
            {
                var isEven = item % 2 == 0;
                result.Add(new Result
                {
                    number = item,
                    IsEven = isEven
                });
                if (isEven)
                    sum += item;
            }
            int counter = 0;
            foreach (var item in queries)
            {
                var n = item[0];
                var index = item[1];
                var temp = result[index].number;

                if (temp % 2 == 0)
                    sum -= temp;

                var total = temp + n;
                if (total % 2 == 0)
                    sum += total;

                result[index].number = total;
                output[counter++] = sum;
            }
            return output;
        }
    }
}

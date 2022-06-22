using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1313_Decompress_Run_Length_Encoded_List
    {

        /// <summary>
        /// Runtime: 180 ms, faster than 71.25% of C# online submissions for Decompress Run-Length Encoded List.
        /// Memory Usage: 45.5 MB, less than 73.75% of C# online submissions for Decompress Run-Length Encoded List.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] DecompressRLElist(int[] nums)
        {
            var result = new List<int>();
            for (int i = 0; i < nums.Length; i = i + 2)
            {
                var freq = nums[i];
                var val = nums[i + 1];
                for (int j = 0; j < freq; j++)
                {
                    result.Add(val);
                }
            }
            return result.ToArray();
        }
    }
}

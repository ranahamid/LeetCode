using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1726
    {
        /// <summary>
        /// Runtime: 241 ms, faster than 85.71% of C# online submissions for Tuple with Same Product.
        /// Memory Usage: 85.5 MB, less than 14.29% of C# online submissions for Tuple with Same Product.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int TupleSameProduct(int[] nums)
        {
            var result = 0;
            var dic = new Dictionary<long, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    var prod = nums[i] * nums[j];
                    if (dic.ContainsKey(prod))
                    {
                        result += dic[prod] * 8;
                    }
                    dic.TryAdd(prod, 0);
                    dic[prod]++;
                }
            }
            return result;
        }
        #region TLE
        public int TupleSameProduct_TLE(int[] nums)
        {
            var result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    for (var k = 0; k < nums.Length; k++)
                    {
                        for (int l = 0; l < nums.Length; l++)
                        {
                            if (i != j && j != k && k != l && i != k && i != l && j != l)
                            {
                                if (nums[i] * nums[j] == nums[k] * nums[l])
                                    result++;
                            }
                        }
                    }
                }
            }
            return result;
        }
        #endregion
    }
}

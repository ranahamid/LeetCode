using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _760
    {
        /// <summary>
        /// Runtime: 210 ms, faster than 24.56% of C# online submissions for Find Anagram Mappings.
        /// Memory Usage: 41.3 MB, less than 26.32% of C# online submissions for Find Anagram Mappings.
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public int[] AnagramMappings(int[] nums1, int[] nums2)
        {
            var result = new int[nums1.Length];
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums2[j] == nums1[i])
                    {
                        result[i] = j;
                        break;
                    }
                }
            }
            return result;
        }



        /// <summary>
        /// Runtime: 272 ms, faster than 5.26% of C# online submissions for Find Anagram Mappings.
        /// Memory Usage: 41.3 MB, less than 38.60% of C# online submissions for Find Anagram Mappings.
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public int[] AnagramMappings_2(int[] nums1, int[] nums2)
        {
            var result = new int[nums1.Length];
            var dic = new Dictionary<int, int>();

            for (int j = 0; j < nums2.Length; j++)
            {
                if (!dic.ContainsKey(nums2[j]))
                {
                    dic[nums2[j]] = j;
                }
            }
            for (int i = 0; i < nums1.Length; i++)
            {
                if (dic.ContainsKey(nums1[i]))
                {
                    result[i] = dic[nums1[i]];
                }
            }
            return result;
        }



    }
}

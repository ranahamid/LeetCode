using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Biweekly_Contest_88
{
    internal class _2425
    {

        /// <summary>
        /// Runtime 403 ms Beats 100
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public int XorAllNums_1(int[] nums1, int[] nums2)
        {
            int length1 = nums1.Length;
            int length2 = nums2.Length;
            int result = 0;

            if (length1 % 2 == 1)
                for (int i = 0; i < length2; i++)
                    result = result ^ nums2[i];
            if (length2 % 2 == 1)
                for (int i = 0; i < length1; i++)
                    result = result ^ nums1[i];
            return result;
        }

        /// <summary>
        /// Runtime 393 ms Beats 100%
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public int XorAllNums(int[] nums1, int[] nums2)
        {
            int length1 = nums1.Length;
            int length2 = nums2.Length;
            int first = 0, second = 0;

            for (int i = 0; i < length2; i++)
                second = second ^ nums2[i];

            for (int i = 0; i < length1; i++)
                first = first ^ nums1[i];

            int result = 0;
            if (length2 % 2 == 0 && length1 % 2 == 1)
                result = second;

            else if (length1 % 2 == 0 && length2 % 2 == 0)
                result = 0;

            else if (length2 % 2 == 1 && length1 % 2 == 1)
                result = first ^ second;

            else if (length2 % 2 == 1 && length1 % 2 == 0)
                result = first;

            return result;
        }
    }
}

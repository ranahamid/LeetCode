using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _88_Merge_Sorted_Array
    {
        /// <summary>
        /// Runtime: 182 ms, faster than 60.27% of C# online submissions for Merge Sorted Array.
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] result = new int[m];
            var nums1Temp = nums1.Take(m).ToList();
            var num2Temp = nums2.ToList();
            nums1Temp.AddRange(num2Temp);
            nums1Temp.Sort();
            var len = m + n;
            for (int i = 0; i < len; i++)
            {
                nums1[i] = nums1Temp[i];
            }
        }

        /// <summary>
        /// Runtime: 256 ms, faster than 9.69% of C# online submissions for Merge Sorted Array.
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        public void Merge_2(int[] nums1, int m, int[] nums2, int n)
        {
            int[] result = new int[m];
            var nums1Temp = nums1.Take(m).ToList();
            var num2Temp = nums2.ToList();
            nums1Temp.AddRange(num2Temp);
            nums1Temp.Sort();

            var res = nums1Temp.ToArray();
            var counter = 0;
            foreach (var item in res)
            {
                nums1[counter++] = item;
            }

        }
    }
}

namespace LeetCode
{
    public class _496__Next_Greater_Element_I {
        /// <summary>
        /// Runtime: 199 ms, faster than 54.84% of C# online submissions for Next Greater Element I.
        /// Memory Usage: 41.5 MB, less than 96.37% of C# online submissions for Next Greater Element I.
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public static int [] NextGreaterElement(int[] nums1, int[] nums2)
        {
            int[] result = new int[nums1.Length];
            for (int i = 0; i < nums1.Length; i++)
            {
                bool isFound = false;
                int res = -1;
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        isFound = true;
                    }

                    if (isFound && nums2[j]> nums1[i])
                    {
                        res = nums2[j];
                        result[i] = res;
                        break;
                    }
                    result[i] = res;
                }
            }

            return result;
        }

    }
}
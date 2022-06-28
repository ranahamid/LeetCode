namespace LeetCode
{
    public class _2057__Smallest_Index_With_Equal_Value
    {
        /// <summary>
        /// Runtime: 135 ms, faster than 53.85% of C# online submissions for Smallest Index With Equal Value.
        /// Memory Usage: 39.5 MB, less than 53.85% of C# online submissions for Smallest Index With Equal Value.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int SmallestEqual(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (i% 10 == nums[i])
                    return i;
            }
            return -1;
        }


    }
}
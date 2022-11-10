namespace LeetCode.Z
{
    public class _852__Peak_Index_in_a_Mountain_Array
    {

        /// <summary>
        /// Runtime: 200 ms, faster than 5.20% of C# online submissions for Peak Index in a Mountain Array.
        /// Memory Usage: 39.2 MB, less than 47.88% of C# online submissions for Peak Index in a Mountain Array.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int PeakIndexInMountainArray(int[] arr)
        {

            var index = 0;
            for (int i = 1; i < arr.Length; i++)
            {

                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                    return i;
            }
            return index;
        }
    }
}
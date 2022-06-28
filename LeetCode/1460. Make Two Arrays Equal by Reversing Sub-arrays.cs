using System;

namespace LeetCode
{
    public class _1460__Make_Two_Arrays_Equal_by_Reversing_Sub_arrays
    {
        /// <summary>
        /// Runtime: 106 ms, faster than 92.86% of C# online submissions for Make Two Arrays Equal by Reversing Sub-arrays.
        /// Memory Usage: 42.4 MB, less than 25.00% of C# online submissions for Make Two Arrays Equal by Reversing Sub-arrays.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="arr"></param>
        /// <returns></returns>
        public bool CanBeEqual(int[] target, int[] arr)
        {
            if (target.Length != arr.Length)
                return false;
            Array.Sort(target);
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (target[i] != arr[i])
                    return false;
            }

            return true;
        }

    }
}
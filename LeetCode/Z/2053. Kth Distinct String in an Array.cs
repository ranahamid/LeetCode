using System.Collections.Generic;

namespace LeetCode.Z
{
    public class _2053__Kth_Distinct_String_in_an_Array
    {

        /// <summary>
        /// Runtime: 84 ms, faster than 100.00% of C# online submissions for Kth Distinct String in an Array.
        /// Memory Usage: 43.1 MB, less than 11.86% of C# online submissions for Kth Distinct String in an Array.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static string KthDistinct(string[] arr, int k)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dictionary.ContainsKey(arr[i]))
                {
                    dictionary[arr[i]]++;
                }
                else
                {
                    dictionary[arr[i]] = 1;
                }
            }

            var counter = 0;
            foreach (var item in dictionary)
            {
                if (item.Value == 1)
                {
                    counter++;
                    if (k == counter)
                        return item.Key;
                }
            }

            return "";
        }



    }
}
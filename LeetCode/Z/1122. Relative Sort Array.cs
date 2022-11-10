using System.Linq;

namespace LeetCode.Z
{
    public class _1122__Relative_Sort_Array
    {

        /// <summary>
        /// Runtime: 178 ms, faster than 61.64% of C# online submissions for Relative Sort Array.
        /// Memory Usage: 41.6 MB, less than 30.82% of C# online submissions for Relative Sort Array.
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        public static int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            var result = new int[arr1.Length];
            var intersect = arr1.Where(x => !arr2.Contains(x)).ToList();
            var counter = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                result[counter++] = arr2[i];
                var values = arr1.Where(x => x == arr2[i]).ToList();
                for (int j = 0; j < values.Count - 1; j++)
                {
                    result[counter++] = values[j];
                }
            }
            intersect.Sort();
            foreach (var item in intersect)
            {
                result[counter++] = item;
            }
            return result;
        }


    }
}
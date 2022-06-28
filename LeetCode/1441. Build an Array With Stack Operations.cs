using System.Collections.Generic;

namespace LeetCode
{
    public class _1441__Build_an_Array_With_Stack_Operations
    {
        /// <summary>
        /// Runtime: 150 ms, faster than 100.00% of C# online submissions for Build an Array With Stack Operations.
        /// Memory Usage: 45.6 MB, less than 6.82% of C# online submissions for Build an Array With Stack Operations.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static IList<string> BuildArray(int[] target, int n)
        {
            var counter = 0;
            List<string> result = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (counter >= target.Length)
                    break;
                if (target[counter] == i)
                {
                    counter++;
                    result.Add("Push");
                }
                else
                {
                    result.Add("Push");
                    result.Add("Pop");
                }
            }

            return result;
        }
    }
}
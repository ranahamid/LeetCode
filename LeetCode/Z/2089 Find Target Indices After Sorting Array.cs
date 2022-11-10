using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2089_Find_Target_Indices_After_Sorting_Array
    {


        /// <summary>
        /// Runtime: 239 ms, faster than 21.21% of C# online submissions for Find Target Indices After Sorting Array.
        /// Memory Usage: 41.7 MB, less than 92.73% of C# online submissions for Find Target Indices After Sorting Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public IList<int> TargetIndices(int[] nums, int target)
        {
            IList<int> result = new List<int>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    result.Add(i);
                }
                else if (nums[i] > target)
                    return result;
            }
            return result;
        }


        /// <summary>
        /// Runtime: 226 ms, faster than 29.70% of C# online submissions for Find Target Indices After Sorting Array.
        /// Memory Usage: 41.7 MB, less than 83.64% of C# online submissions for Find Target Indices After Sorting Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public IList<int> TargetIndices_2(int[] nums, int target)
        {
            IList<int> result = new List<int>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}

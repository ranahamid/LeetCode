using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1243
    {
        /// <summary>
        /// Runtime: 147 ms, faster than 83.33% of C# online submissions for Array Transformation.
        /// Memory Usage: 41.9 MB, less than 16.67% of C# online submissions for Array Transformation.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public IList<int> TransformArray(int[] arr)
        { 
            var list = new List<int>(arr);
            while (true)
            {
                var isChanged = false;
                for (int i = 1; i < arr.Length - 1; i++)
                {
                    if (arr[i] < arr[i - 1] && arr[i] < arr[i + 1])
                    {
                        list[i] = arr[i] + 1;
                        isChanged = true;
                    }
                    if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                    {
                        list[i] = arr[i] - 1;
                        isChanged = true;
                    }
                }

                var index = 0;
                foreach (var item in list)
                {
                    arr[index++] = item;
                }
                if (!isChanged)
                    return arr.ToList();
            }
        }
    }
}

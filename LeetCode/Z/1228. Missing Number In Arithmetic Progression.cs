using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1228
    {
        /// <summary>
        /// Runtime: 85 ms, faster than 100.00% of C# online submissions for Missing Number In Arithmetic Progression.
        /// Memory Usage: 38.9 MB, less than 6.25% of C# online submissions for Missing Number In Arithmetic Progression.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int MissingNumber_1(int[] arr)
        {
            return (arr.Length + 1) * (arr.FirstOrDefault() + arr.LastOrDefault()) / 2 - arr.Sum();
        }
        /// <summary>
        /// Runtime: 132 ms, faster than 50.00% of C# online submissions for Missing Number In Arithmetic Progression.
        /// Memory Usage: 37.7 MB, less than 37.50% of C# online submissions for Missing Number In Arithmetic Progression.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int MissingNumber(int[] arr)
        {
            if (arr.Sum() == arr[0] * arr.Length)
                return arr[0];
            Array.Sort(arr);
            Dictionary<int, int> dic = new Dictionary<int, int>();
            var progress = (arr.LastOrDefault() - arr.FirstOrDefault()) / arr.Length;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] - arr[i] != progress)
                {
                    return progress + arr[i];
                }
            }
            return 0;
        }

        /// <summary>
        /// Runtime: 116 ms, faster than 68.75% of C# online submissions for Missing Number In Arithmetic Progression.
        /// Memory Usage: 38 MB, less than 6.25% of C# online submissions for Missing Number In Arithmetic Progression.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int MissingNumber_2(int[] arr)
        {
            if (arr.Sum() == arr[0] * arr.Length)
                return arr[0];
            Array.Sort(arr);
            Dictionary<int, int> dic = new Dictionary<int, int>();
            var progress = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                var diff = arr[i] - arr[i - 1];
                if (dic.ContainsKey(diff))
                {
                    progress = diff;
                    break;
                }
                else
                {
                    dic[diff] = 1;
                }
            }
            if (progress == 0) //if length is 3
            {
                progress = Math.Min(arr[1] - arr[0], arr[2] - arr[1]);
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] - arr[i] != progress)
                {
                    return progress + arr[i];
                }
            }
            return 0;
        }
    }
}

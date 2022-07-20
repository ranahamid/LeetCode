using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.NOT_SUBMITTED
{
    internal class _384
    {
        /// <summary>
        /// Runtime: 272 ms, faster than 68.39% of C# online submissions for Shuffle an Array.
        /// Memory Usage: 54.9 MB, less than 20.73% of C# online submissions for Shuffle an Array.
        /// </summary>
        List<int> array;
        Random rd = new Random();
        public _384(int[] nums)
        {
            array = new List<int>(nums);
        }

        public int[] Reset()
        {
            return array.ToArray();
        }

        public int[] Shuffle()
        {
            List<int> randomList = new List<int>();
            var arrayCopy = new List<int>();
            foreach (var item in array)
            {
                arrayCopy.Add(item);
            }
            while (arrayCopy.Count != 0)
            {
                var index = rd.Next(0, arrayCopy.Count);
                randomList.Add(arrayCopy[index]);
                arrayCopy.RemoveAt(index);
            }
            return randomList.ToArray();
        }
    }
}

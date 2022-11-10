using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _992
    {
        /// <summary>
        /// Runtime: 171 ms, faster than 86.84% of C# online submissions for Subarrays with K Different Integers.
        /// Memory Usage: 50.5 MB, less than 15.79% of C# online submissions for Subarrays with K Different Integers.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int SubarraysWithKDistinct(int[] nums, int k)
        {
            var w1 = new Window();
            var w2 = new Window();
            int left1 = 0, left2 = 0;
            var result = 0;
            foreach (var n in nums)
            {

                w1.Add(n);
                w2.Add(n);
                while (w1.Difference > k)
                    w1.Remove(nums[left1++]);
                while (w2.Difference >= k)
                    w2.Remove(nums[left2++]);

                result += left2 - left1;
            }
            return result;
        }
        public class Window
        {
            public int Difference { get; set; }
            public Dictionary<int, int> Dic;
            public Window()
            {
                Difference = 0;
                Dic = new Dictionary<int, int>();
            }
            public void Add(int x)
            {
                Dic.TryAdd(x, 0);
                Dic[x]++;
                if (Dic[x] == 1)
                    Difference++;
            }
            public void Remove(int x)
            {
                Dic[x]--;
                if (Dic[x] == 0)
                    Difference--;
            }
            public int Distict()
            {
                return Difference;
            }
        }
    }
}

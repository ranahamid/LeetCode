using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    public class SparseVector
    {
        public Dictionary<int, int> dic = new Dictionary<int, int>();
        public SparseVector(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    dic.Add(i, nums[i]);
                }
            }
        }

        // Return the dotProduct of two sparse vectors
        public int DotProduct(SparseVector vec)
        {
            var sum = 0;
            foreach (var item in dic)
            {
                if (vec.dic.ContainsKey(item.Key))
                {
                    var spVal = vec.dic[item.Key];
                    sum += item.Value * spVal;
                }
            }
            return sum;
        }
    }
}

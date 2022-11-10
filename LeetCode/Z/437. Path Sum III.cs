using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _437
    {
        /// <summary>
        /// Runtime: 169 ms, faster than 37.22% of C# online submissions for Path Sum III.
        /// Memory Usage: 39.3 MB, less than 62.46% of C# online submissions for Path Sum III.
        /// </summary>
        Dictionary<long, int> dic = new Dictionary<long, int>();
        int counter = 0;
        public int PathSum(TreeNode root, int targetSum)
        {
            dic.Add(0, 1);
            Traverse(root, 0, targetSum);
            return counter;
        }
        public void Traverse(TreeNode root, long currentSum, int k)
        {
            if (root == null)
                return;
            currentSum += root.val;
            if (dic.ContainsKey(currentSum - k))
                counter += dic[currentSum - k];

            dic.TryAdd(currentSum, 0);
            dic[currentSum]++;

            Traverse(root.left, currentSum, k);
            Traverse(root.right, currentSum, k);

            dic[currentSum]--;
        }
    }
}

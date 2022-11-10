using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _501
    {
        /// <summary>
        /// Runtime: 156 ms, faster than 94.31% of C# online submissions for Find Mode in Binary Search Tree.
        ///  Memory Usage: 47.2 MB, less than 11.38% of C# online submissions for Find Mode in Binary Search Tree.
        /// </summary>
        Dictionary<int, int> dic = new Dictionary<int, int>();
        public int[] FindMode(TreeNode root)
        {
            DFS(root);
            var maxValues = dic.Values.Max();
            var result = new List<int>();
            foreach (var item in dic)
            {
                if (item.Value == maxValues)
                    result.Add(item.Key);
            }
            return result.ToArray();
        }
        public void DFS(TreeNode root)
        {
            if (root == null)
                return;
            if (dic.ContainsKey(root.val))
                dic[root.val]++;
            else
                dic[root.val] = 1;
            DFS(root.left);
            DFS(root.right);
        }
    }
}

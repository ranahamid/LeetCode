using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _872
    {
        /// <summary>
        /// Runtime: 157 ms, faster than 44.04% of C# online submissions for Leaf-Similar Trees.
        /// Memory Usage: 39 MB, less than 66.06% of C# online submissions for Leaf-Similar Trees.
        /// </summary>
        /// <param name="root1"></param>
        /// <param name="root2"></param>
        /// <returns></returns>
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            var res1 = new List<int>();
            var res2 = new List<int>();
            DFS(root1, res1);
            DFS(root2, res2);
            if (res1.Count != res2.Count)
                return false;
            for (int i = 0; i < res1.Count; i++)
            {
                if (res1[i] != res2[i])
                    return false;
            }
            return true;
        }
        public void DFS(TreeNode root, List<int> resultLeaf)
        {
            if (root == null)
                return;
            if (root.left == null && root.right == null)
                resultLeaf.Add(root.val);
            if (root.left != null)
                DFS(root.left, resultLeaf);
            if (root.right != null)
                DFS(root.right, resultLeaf);
        }
    }
}

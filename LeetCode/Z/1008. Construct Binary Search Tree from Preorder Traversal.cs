using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1008
    {
        /// <summary>
        /// Runtime: 100 ms, faster than 79.83% of C# online submissions for Construct Binary Search Tree from Preorder Traversal.
        /// Memory Usage: 37.5 MB, less than 22.69% of C# online submissions for Construct Binary Search Tree from Preorder Traversal.
        /// </summary>
        int pre_idx = 0;
        public TreeNode BstFromPreorder(int[] preorder)
        {
            var inorder = new int[preorder.Length];
            Array.Copy(preorder, inorder, inorder.Length);
            Array.Sort(inorder);

            var counter = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (var item in inorder)
            {
                dic[item] = counter++;
            }

            var node = MakeTree(preorder, dic, 0, preorder.Length - 1);
            return node;
        }
        public TreeNode MakeTree(int[] preorder, Dictionary<int, int> dic, int start, int end)
        {
            // if there is no elements to construct subtrees
            if (start > end)
                return null;

            int rootVal = preorder[pre_idx];
            var root = new TreeNode(rootVal);

            int index = dic[rootVal];

            pre_idx++;
            root.left = MakeTree(preorder, dic, start, index - 1);
            root.right = MakeTree(preorder, dic, index + 1, end);
            return root;
        }
    }
}

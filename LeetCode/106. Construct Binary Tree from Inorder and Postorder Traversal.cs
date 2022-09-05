using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _106
    {
        /// <summary>
        /// Runtime: 101 ms, faster than 89.04% of C# online submissions for Construct Binary Tree from Inorder and Postorder Traversal.
        /// Memory Usage: 40.7 MB, less than 17.81% of C# online submissions for Construct Binary Tree from Inorder and Postorder Traversal.
        /// </summary>
        /// <param name="inorder"></param>
        /// <param name="postorder"></param>
        /// <returns></returns>
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            //var inorder = new int[preorder.Length];
            //Array.Copy(preorder, inorder, inorder.Length);
            //Array.Sort(inorder);
            int post_idx = postorder.Length - 1;
            var counter = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (var item in inorder)
            {
                dic[item] = counter++;
            }

            var node = MakeTree(postorder, dic, 0, postorder.Length - 1, ref post_idx);
            return node;
        }
        public TreeNode MakeTree(int[] postorder, Dictionary<int, int> dic, int start, int end, ref int post_idx)
        {
            // if there is no elements to construct subtrees
            if (start > end)
                return null;

            int rootVal = postorder[post_idx];
            var root = new TreeNode(rootVal);

            int index = dic[rootVal];

            post_idx--;
            //The intuition behind it is that since postorder: LEFT → RIGHT → ROOT, so when we go in reverse order,
            //we must construct the tree in the order of: ROOT → RIGHT → LEFT

            //post order sequence is left --> right-- > root.So since here we are building it backward, it should go from root-- > right-- > left
            root.right = MakeTree(postorder, dic, index + 1, end, ref post_idx);
            root.left = MakeTree(postorder, dic, start, index - 1, ref post_idx);

            return root;
        }
    }
}

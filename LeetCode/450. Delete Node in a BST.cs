using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _450
    {
        /// <summary>
        /// Runtime: 97 ms, faster than 97.85% of C# online submissions for Delete Node in a BST.
        /// Memory Usage: 44.2 MB, less than 9.68% of C# online submissions for Delete Node in a BST.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int Successor(TreeNode root)
        {
            if (root != null)
            {
                root = root.right;
                while (root.left != null)
                    root = root.left;
                return root.val;
            }
            return 0;
        }
        public int Predessor(TreeNode root)
        {
            if (root != null)
            {
                root = root.left;
                while (root.right != null)
                    root = root.right;
                return root.val;
            }
            return 0;
        }
        public TreeNode DeleteNode(TreeNode root, int key)
        {
            if (root == null)
                return null;
            if (key > root.val)
            {

                root.right = DeleteNode(root.right, key);
            }
            else if (key < root.val)
            {

                root.left = DeleteNode(root.left, key);
            }
            else
            {
                if (root.left == null && root.right == null)
                    root = null;
                else if (root.right != null)
                {
                    root.val = Successor(root);
                    root.right = DeleteNode(root.right, root.val);
                }
                else
                {
                    root.val = Predessor(root);
                    root.left = DeleteNode(root.left, root.val);
                }
            }
            return root;
        }
    }
}
